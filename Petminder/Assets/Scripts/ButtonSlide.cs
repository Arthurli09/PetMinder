using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ButtonSlide : MonoBehaviour
{
    Vector2 cPos;
    Vector2 tStPos;
    Vector2 tFnPos;
    float dis;
    float scale;
    int sign;
    const int clickPos = 288;
    const int mp = 768;
    const int line = 450;
    const float f = 2f;
    const float sf = 0.0005f;
    bool slide = false;
    Color c;
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
                cPos = transform.position;
                tStPos = touch.position;
                if(tStPos.y <= line){
                    slide = true;
                }
            }
            else if(touch.phase == TouchPhase.Moved && slide){
                //set a maximum sliding speed later
                tFnPos = touch.position;
                cPos.x += tFnPos.x - tStPos.x;
                tStPos.x = tFnPos.x;
                if(cPos.x > mp+2*clickPos){
                    cPos.x -= (cPos.x - (mp+2*clickPos))/f;
                }
                else if(cPos.x < mp-2*clickPos){
                    cPos.x -= (cPos.x - (mp-2*clickPos))/f;
                }
                transform.position = new Vector2(cPos.x, cPos.y);
                scale = sf*Math.Abs(cPos.x - mp);
                transform.localScale = new Vector2(1 - scale, 1 - scale);
                c = GetComponent<Image>().color;
                c.a = 1 - scale;
                GetComponent<Image>().color = c;
            }
            else if(touch.phase == TouchPhase.Ended){
                //add animation of going (slowly and smoothly) to click position later
                dis = (cPos.x - mp)%clickPos;
                if(cPos.x > mp+2*clickPos){
                    transform.position = new Vector2(mp+2*clickPos, cPos.y);
                }
                else if(cPos.x < mp-2*clickPos){
                    transform.position = new Vector2(mp-2*clickPos, cPos.y);
                }
                else if(Math.Abs(dis) >= clickPos/2){
                    sign = (int)(dis/Math.Abs(dis));
                    transform.position = new Vector2(cPos.x+sign*clickPos-dis, cPos.y);
                }
                else{
                    transform.position = new Vector2(cPos.x-dis, cPos.y);
                }
                slide = false;
            }
        }
    }
}
