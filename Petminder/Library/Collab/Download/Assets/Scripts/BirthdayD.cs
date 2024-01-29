using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirthdayD : MonoBehaviour
{
    GameObject source;
    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.Find("ContInfo");
        List<Pet> l = source.GetComponent<User>().getPets();
        int ind = source.GetComponent<User>().getPet();
        GetComponent<TextMeshProUGUI>().text = l[ind].getBDay();
    }
    // Update is called once per frame
    void Update()
    {
        List<Pet> l = source.GetComponent<User>().getPets();
        int ind = source.GetComponent<User>().getPet();
        GetComponent<TextMeshProUGUI>().text = l[ind].getBDay();
    }
}
