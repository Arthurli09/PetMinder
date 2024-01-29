using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuySystem : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    GameObject source;
    int curID;
    int price;
    public void checkMoney(){
        source = GameObject.Find("ContInfo");
        int currency = source.GetComponent<User>().getMoney();
        price = source.GetComponent<OneTimeItemsInfo>().getPrice(curID);;
        if(currency >= price){
            appear(panel1);
        }
        else{
            appear(panel2);
        }
    }

    public void setID(int ID){
        curID = ID;
    }

    public void buy(){
        source = GameObject.Find("ContInfo");
        source.GetComponent<User>().increMoney(-price);
        //source.GetComponent<
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void appear(GameObject o){
        o.SetActive(true);
    }

    public void disappear(GameObject o){
        o.SetActive(false);
    }
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
