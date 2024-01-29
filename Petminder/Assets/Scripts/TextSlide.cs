using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextSlide : MonoBehaviour
{
    public GameObject but;
    Vector2 pos;
    Vector2 cPos;
    float disX;
    float disY;
    Color cB;
    Color c;
    // Start is called before the first frame update
    void Start()
    {
        pos = but.transform.position;
        cPos = transform.position;
        disX = pos.x - cPos.x;
        disY = pos.y - cPos.y;
        transform.localScale = but.transform.localScale;
        c = GetComponent<TextMeshProUGUI>().color;
        cB = but.GetComponent<Image>().color;
        c.a = cB.a;
        GetComponent<TextMeshProUGUI>().color = c;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(pos.x - disX, pos.y - disY);
        pos = but.transform.position;
        transform.localScale = but.transform.localScale;
        c = GetComponent<TextMeshProUGUI>().color;
        cB = but.GetComponent<Image>().color;
        c.a = cB.a;
        GetComponent<TextMeshProUGUI>().color = c;
    }
}
