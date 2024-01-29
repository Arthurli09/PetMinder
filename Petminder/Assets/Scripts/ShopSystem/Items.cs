using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Items : MonoBehaviour
{
    GameObject shop;
    public GameObject itemPrefab;
    public Transform grid;
    int ID;

    //public item source file
    //public GameObject source;

    // Start is called before the first frame update
    void Start()
    {
        shop = GameObject.Find("ContInfo");
        FillList();
    }

    void FillList() {
        for (int i = 0; i < shop.GetComponent<OneTimeItemsInfo>().getLength(); i++) {
            ID = i;
            /*if(!shop.GetComponent<OneTimeItemsInfo>().isBought(ID)){
                Instantiate(itemPrefab, grid);
            }*/
            Instantiate(itemPrefab, grid);
        }
        
    }

    public int getID(){
        return ID;
    }

    //holderScript.itemName.text = itemsList[i].name;
            //holderScript.itemPrice.text = itemsList[i].getPrice().ToString();
            //holderScript.itemImage.sprite = resources.load(itemsList[i].getImage());
            //holderScript.itemID = itemsList[i].ID;
            /*if (itemsList[i].bought)
            {
                holderScript.itemImage.sprite = itemsList[i].boughtSprite;
            }
            else
            {
                holderScript.itemImage.sprite = itemsList[i].unboughtSprite;
            }*/
}



