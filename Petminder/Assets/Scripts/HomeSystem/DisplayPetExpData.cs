using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPetExpData : MonoBehaviour
{
    GameObject bar;
    // Start is called before the first frame update
    void Start()
    {
         bar = GameObject.Find("PetExp");
         GetComponent<TextMeshProUGUI>().text = "Level: " + bar.GetComponent<FillPetExp>().getLvl().ToString() + " " + bar.GetComponent<FillPetExp>().getCurExp().ToString() + "/" + bar.GetComponent<FillPetExp>().getTotExp().ToString();
    }

    // Update is called once per frame
    void Update()
    {
         GetComponent<TextMeshProUGUI>().text = "Level: " + bar.GetComponent<FillPetExp>().getLvl().ToString() + " " + bar.GetComponent<FillPetExp>().getCurExp().ToString() + "/" + bar.GetComponent<FillPetExp>().getTotExp().ToString();
    }
}
