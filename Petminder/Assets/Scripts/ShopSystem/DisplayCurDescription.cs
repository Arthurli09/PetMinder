using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCurDescription : MonoBehaviour
{
    GameObject source;
    int curID;
    
    // Start is called before the first frame update
    void Start()
    {
        curID = 0;
        source = GameObject.Find("ContInfo");
        GetComponent<TextMeshProUGUI>().text = source.GetComponent<OneTimeItemsInfo>().getDescription(curID);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = source.GetComponent<OneTimeItemsInfo>().getDescription(curID);
    }

    public void setID(int ID){
        curID = ID;
    }
}
