using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalAnimation : MonoBehaviour
{
    public GameObject image;
    Color c;
    bool show = false;
    bool opaque = false;
    float scale = 0;
    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(false);
        c = image.GetComponent<Image>().color;
        c.a = 0;
        image.GetComponent<Image>().color = c;
    }

    public void Transport(){
        image.SetActive(true);
        c = image.GetComponent<Image>().color;
        c.a = 0;
        image.GetComponent<Image>().color = c;
        show = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(show){
            c.a+=(float)0.01;
            image.GetComponent<Image>().color = c;
        }
        if(c.a >= 1&&show){
            show = false;
            opaque = true;
        }
        if(opaque){
            scale += 0.015f;
            image.transform.localScale = new Vector2(1+scale, 1+scale);
        }
    }
}
