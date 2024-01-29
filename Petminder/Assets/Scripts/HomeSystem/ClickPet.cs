using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickPet : MonoBehaviour
{
    public GameObject sentence;
    float t;
    string[] sentences = {"Slimy, Slimy!","Hello!","Did you read today"};
    // Start is called before the first frame update
    void Start()
    {
        sentence.SetActive(false);
        t = Time.time - 1;
    }
    public void speak(){
        if(Time.time-t > 1){
            sentence.GetComponent<TextMeshProUGUI>().text = sentences[(int)Random.Range(0, sentences.Length)];
            sentence.SetActive(true);
            GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/happy_slime");
            StartCoroutine(wait(1));
            t = Time.time;
        }
    }

    IEnumerator wait(float second){
        yield return new WaitForSeconds(second);
        sentence.SetActive(false);
        GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/slime");
    }
}
