using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayUsrExp : MonoBehaviour
{
    //bar.GetComponent<FillBar>().x;
    //bar.GetComponent<FillBar>().y;
    GameObject bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = GameObject.Find("ExperienceBar");
        GetComponent<TextMeshProUGUI>().text = "Level: " + bar.GetComponent<FillUsrExp>().getLvl().ToString() + " " + bar.GetComponent<FillUsrExp>().getCurExp().ToString() + "/" + bar.GetComponent<FillUsrExp>().getTotExp().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Level: " + bar.GetComponent<FillUsrExp>().getLvl().ToString() + " " + bar.GetComponent<FillUsrExp>().getCurExp().ToString() + "/" + bar.GetComponent<FillUsrExp>().getTotExp().ToString();
    }
}
