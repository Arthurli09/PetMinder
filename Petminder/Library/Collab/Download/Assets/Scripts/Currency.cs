using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Currency : MonoBehaviour
{
    GameObject source;
    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.Find("ContInfo");
        GetComponent<TextMeshProUGUI>().text = source.GetComponent<User>().getMoney().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            source.GetComponent<User>().increMoney(1);
        }
        GetComponent<TextMeshProUGUI>().text = source.GetComponent<User>().getMoney().ToString();
    }
}
