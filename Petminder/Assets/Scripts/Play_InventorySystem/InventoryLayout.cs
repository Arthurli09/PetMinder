using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryLayout : MonoBehaviour
{
    public GameObject source;
    public GameObject itemHolderPrefab;
    public Transform grid;

    public List<int> itemIDList;
    public List<GameObject> holderList;

    // The IndexLayoutRange is a single number signify the hundredth digit that satisfy the charter of accounts
    public int indexLayoutRange;

    void Start()
    {
        holderList = new List<GameObject>();

        // Linked the list to the list of books that's in User
        source = GameObject.Find("ContInfo");
        // Passed by reference, if User updates, then bookList updates
        itemIDList = source.GetComponent<User>().getOneTimeItems();
        FillList();
    }

    public void FillList()
    {
        for (int i = 0; i < itemIDList.Count; i++)
        {
            // Get the ID of the current item
            int ID = itemIDList[i];

            // Ignore items that are not in the current display range
            if ((int)(ID/100) != indexLayoutRange)
            {
                continue;
            }

            // Begin processing and displaying the book
            GameObject holder = Instantiate(itemHolderPrefab, grid, false);
            InventoryItemHolder holderScript = holder.GetComponent<InventoryItemHolder>();

            // Fills in information for the book items
            holderScript.nameText.text = OneTimeItemsInfo.itemInfo.getName(i);
            holderScript.imageDir = OneTimeItemsInfo.itemInfo.getImage(i);
            holderScript.imageSprite.GetComponent<Image>().sprite = Resources.Load<Sprite>(holderScript.imageDir);

            // Add the itemholders to the list
            holderList.Add(holder);
        }

    }

}
