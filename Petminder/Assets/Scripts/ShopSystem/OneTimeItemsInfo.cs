using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeItemsInfo : MonoBehaviour
{
    // Static variable to be referenced
    public static OneTimeItemsInfo itemInfo;

    GameObject source;


    /* ID Range:
     * 000 - 099: Pets
     * 100 - 199: Accessories
     * 200 - 299: Food
     * 300 - 399: Soap
     * */

    List<int> ID;
    List<int> price;
    List<string> itemName;
    List<string> image;
    List<string> description;
    List<bool> bought;

    //List<UsableItemTemplate> itemList;

    // Start is called before the first frame update
    void Start()
    {
        /*source = GameObject.Find("ContInfo");
        itemList = new List<UsableItemTemplate>();

        itemList.Add(new UsableItemTemplate(0, 50, "Bluepie", "Images/normal_ghost", "Bluebie comes from a distant planet called Pandora", checkBought(0), 0));
        itemList.Add(new UsableItemTemplate(1, 50, "Stompie", "Images/Stompie", "Intelligent stone that loves reading.", checkBought(1), 0));*/

        itemInfo = this;

        source = GameObject.Find("ContInfo");
        ID = new List<int>();
        price = new List<int>();
        itemName = new List<string>();
        image = new List<string>();
        description = new List<string>();
        bought = new List<bool>();

        //Bluebie
        ID.Add(0);
        price.Add(50);
        itemName.Add("Bluepie");
        image.Add("Images/normal_ghost");
        description.Add("Bluebie comes from a distant planet called Pandora.");
        //bought.Add(checkBought(0));
        
        //Stompie
        ID.Add(1);
        price.Add(100);
        itemName.Add("Stompie");
        image.Add("Images/Stompie");
        description.Add("Intelligent stone that loves reading.");
        //bought.Add(checkBought(1));

        //Bow
        ID.Add(100);
        price.Add(100);
        itemName.Add("Bow Tie");
        image.Add("Images/bow");
        description.Add("A nice looking bow for your pets!");
        //bought.Add(checkBought(2));
    }

    /*public int GetSize()
    {
        return itemList.Count;
    }*/

    public int getLength(){
        return ID.Count;
    }

    public int getID(int ind){
        return ID[ind];
    }

    public int getPrice(int ind){
        return price[ind];
    }

    public string getName(int ind){
        return itemName[ind];
    }

    public string getImage(int ind){
        return image[ind];
    }

    public string getDescription(int ind){
        return description[ind];
    }

    public bool isBought(int ind){
        return bought[ind];
    }

    bool checkBought(int ind){
        return (source.GetComponent<User>().getOneTimeItems().Find(x => x == ind)!=-1);
    }
}
