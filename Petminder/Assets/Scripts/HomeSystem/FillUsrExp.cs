using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Firebase;
//using Firebase.Auth;
//using Firebase.Database;
//using Firebase.Unity.Editor;
//using Firebase.Extensions;

public class FillUsrExp : MonoBehaviour
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
    float barlvl;

    //Firebase.Auth.FirebaseAuth auth;
    //Firebase.Auth.FirebaseUser user;

    // Start is called before the first frame update
    void Start()
    {
        /*FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://petminder-98607.firebaseio.com/");
        DatabaseReference databaseReference = FirebaseDatabase.DefaultInstance.RootReference;
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        user = auth.CurrentUser;
        string uId = user.UserId;
        */

        source = GameObject.Find("ContInfo");
        curExp = source.GetComponent<User>().getExp();
        lvl = source.GetComponent<User>().getLvl();
        cons = source.GetComponent<User>().getConst();
        cap = source.GetComponent<User>().getLvlCap();
        totExp = cons*lvl;
        barlvl = (float) curExp/totExp;
        GetComponent<Image>().fillAmount = barlvl;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            source.GetComponent<User>().increExp(100);
        }
        curExp = source.GetComponent<User>().getExp();
        if(curExp>=totExp){
            //change later (needs a more slick equation)
            if(lvl+1>cap){
                source.GetComponent<User>().increExp(totExp-curExp);
            }
            else{
                source.GetComponent<User>().increExp(-totExp);
                source.GetComponent<User>().increLvl();
                lvl = source.GetComponent<User>().getLvl();
            }
            totExp = cons*lvl;
            curExp = source.GetComponent<User>().getExp();
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
