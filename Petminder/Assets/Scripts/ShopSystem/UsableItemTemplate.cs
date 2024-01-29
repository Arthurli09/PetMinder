using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableItemTemplate : MonoBehaviour
{
    // Chapter of accounts for the IDs
    // 000 - 099: Pets
    // 100 - 199: Accessories
    // 200 - 299: Food
    // 300 - 399: Soap

    int ID;
    int price;
    string itemName;
    string image;
    string description;

    // Used for only one-time items ID: 000-199
    bool bought;

    // Used for consumable items ID: 200-399
    int count;

    public UsableItemTemplate(int ID, int price, string itemName, string image, string description, bool bought, int count)
    {
        this.ID = ID;
        this.price = price;
        this.itemName = itemName;
        this.image = image;
        this.description = description;
        this.bought = bought;
        this.count = count;
    }

    public int GetID()
    {
        return ID;
    }
  
    public int GetPrice()
    {
        return price;
    }

    public string GetName()
    {
        return itemName;
    }

    public string GetImage()
    {
        return image;
    }

    public string GetDescription()
    {
        return description;
    }

    public bool IsBought()
    {
        return bought;
    }

    public int GetCount()
    {
        return count;
    }
}
