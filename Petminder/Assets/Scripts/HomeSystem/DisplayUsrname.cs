using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayUsrname : MonoBehaviour
{
    GameObject source;
    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.Find("ContInfo");
        GetComponent<TextMeshProUGUI>().text = source.GetComponent<User>().getName();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = source.GetComponent<User>().getName();
    }
}
