using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notifications : MonoBehaviour
{
    public GameObject notifImage;
    public GameObject source;


    void Start()
    {
        source = GameObject.Find("ContInfo");
        bool check;
        check = source.GetComponent<User>().getChallengeNotif();
        if (check)
        {
            notifImage.SetActive(true);
        }
        else
        {
            notifImage.SetActive(false);
        }
    }

   
}
