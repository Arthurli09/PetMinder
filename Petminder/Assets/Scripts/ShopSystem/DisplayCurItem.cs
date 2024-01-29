using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCurItem : MonoBehaviour
{
    GameObject source;
    int curID;
    // Start is called before the first frame update
    void Start()
    {
        curID = 0;
        source = GameObject.Find("ContInfo");
        GetComponent<Image>().sprite = Resources.Load<Sprite>(source.GetComponent<OneTimeItemsInfo>().getImage(curID));
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().sprite = Resources.Load<Sprite>(source.GetComponent<OneTimeItemsInfo>().getImage(curID));
    }

    public void setID(int ID){
        curID = ID;
    }
}
