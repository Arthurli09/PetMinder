using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillPetExp : MonoBehaviour
{
    ///two relative objects that is going to be imported from outside the file
    //(e.g. current experence and level cap)
    //(for testing purposes it is inititalized within the file)
    GameObject source;
    int curExp;
    int totExp;
    int lvl;
    int cons;
    int cap;
    int pet;
    float barlvl;
    List<Pet> l;
    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.Find("ContInfo");
        l = source.GetComponent<User>().getPets();
        pet = source.GetComponent<User>().getPet();
        curExp = l[pet].getExp();
        lvl = l[pet].getLvl();
        cons = l[pet].getConst();
        cap = l[pet].getLvlCap();
        totExp = cons*lvl;
        barlvl = (float) curExp/totExp;
        GetComponent<Image>().fillAmount = barlvl;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            l[pet].increExp(1);
        }
        curExp = l[pet].getExp();
        if(curExp>=totExp){
            //change later (needs a more slick equation)
            if(lvl+1>cap){
                l[pet].increExp(totExp-curExp);
            }
            else{
                l[pet].increExp(-totExp);
                l[pet].increLvl();
                lvl = l[pet].getLvl();
            }
            totExp = cons*lvl;
            curExp = l[pet].getExp();
        }
        barlvl = (float) curExp/totExp;
        GetComponent<Image>().fillAmount = barlvl;
    }

    public int getCurExp(){
        return curExp;
    }

    public int getTotExp(){
        return totExp;
    }

    public int getLvl(){
        return lvl;
    }
}
