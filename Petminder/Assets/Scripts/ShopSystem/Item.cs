using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{
    //public prefab variables
    public GameObject displayImage;
    public TextMeshProUGUI priceText;

    //item attributes
    //int price;
    int ID;
    //string itemName;
    //string image;
    //string description;
    //bool bought;

    void Awake(){
        GameObject items = GameObject.Find("ItemPanel");
        GameObject shop = GameObject.Find("ContInfo");
        ID = items.GetComponent<Items>().getID();
        /*price = shop.GetComponent<OneTimeItemsInfo>().getPrice(ID);
        itemName = shop.GetComponent<OneTimeItemsInfo>().getName(ID);
        image = shop.GetComponent<OneTimeItemsInfo>().getImage(ID);
        description = shop.GetComponent<OneTimeItemsInfo>().getDescription(ID);
        bought = shop.GetComponent<OneTimeItemsInfo>().isBought(ID);*/
        displayImage.GetComponent<Image>().sprite = Resources.Load<Sprite>(shop.GetComponent<OneTimeItemsInfo>().getImage(ID));
        priceText.text = shop.GetComponent<OneTimeItemsInfo>().getPrice(ID).ToString();
    }

    /*public int getID(){
        return ID;
    }*/

    public void click(){
        GameObject shop = GameObject.Find("ContInfo");
        GameObject displayItem = GameObject.Find("CurrentItem");
        GameObject displayDescription = GameObject.Find("CurrentDescription");
        GameObject displayPrice = GameObject.Find("CurrentPrice");
        //GameObject priceValue = GameObject.Find("PriceValue");
        GameObject buyBut = GameObject.Find("BuyButton");
        displayItem.GetComponent<DisplayCurItem>().setID(ID);
        displayDescription.GetComponent<DisplayCurDescription>().setID(ID);
        displayPrice.GetComponent<DisplayCurPrice>().setID(ID);
        //priceValue.GetComponent<DisplayCurPrice>().setID(ID);
        buyBut.GetComponent<BuySystem>().setID(ID);
    }

    /*public int getPrice(){
        return price;
    }

    /*public string getName(){
        return itemName;
    }

    public string getImage(){
        return image;
    }

    public string getDescription(){
        return description;
    }

    public bool isBought(){
        return bought;
    }*/

}
