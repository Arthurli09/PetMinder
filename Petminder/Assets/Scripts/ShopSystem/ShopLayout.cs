using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopLayout : MonoBehaviour
{
    public static ShopLayout shoplayout;

    public GameObject source;
    public GameObject itemHolderPrefab;
    public Transform grid;

    // This indicate the type of items according to chart of accounts that will be listed
    public int IDRange;

    // Manage the Selection
    public int curSelectedItemID;
    public int preSelectedItemID;

    void Start()
    {

    }



}
