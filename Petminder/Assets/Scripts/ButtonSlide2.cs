using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ButtonSlide2 : MonoBehaviour
{
    public GameObject cButton;
    Vector2 pos;
    Vector2 cPos;
    float disX;
    float disY;
    float scale;
    Color c;
    const int mp = 768;
    const float sf = 0.0005f;
    // Start is called before the first frame update
    void Start()
    {
        pos = cButton.transform.position;
        cPos = transform.position;
        disX = pos.x - cPos.x;
        disY = pos.y - cPos.y;
        scale = sf*Math.Abs(cPos.x - mp);
        transform.localScale = new Vector2(1 - scale, 1 - scale);
        c = GetComponent<Image>().color;
        c.a = 1 - scale;
        GetComponent<Image>().color = c;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(pos.x - disX, pos.y - disY);
        pos = cButton.transform.position;
        cPos = transform.position;
        scale = sf*Math.Abs(cPos.x - mp);
        transform.localScale = new Vector2(1 - scale, 1 - scale);
        c = GetComponent<Image>().color;
        c.a = 1 - scale;
        GetComponent<Image>().color = c;
    }
}
