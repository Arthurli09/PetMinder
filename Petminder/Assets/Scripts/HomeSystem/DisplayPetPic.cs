using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPetPic : MonoBehaviour
{
    GameObject source;
    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.Find("ContInfo");
        GetComponent<Image>().sprite = Resources.Load<Sprite>(source.GetComponent<User>().getProfilePic());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
