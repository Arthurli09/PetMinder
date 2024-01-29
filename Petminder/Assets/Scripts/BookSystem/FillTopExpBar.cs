using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillTopExpBar : MonoBehaviour
{
    GameObject source;
    public Image image;

    int totalBookCount;
    int finishedBookCount;

    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.Find("ContInfo");
        finishedBookCount = source.GetComponent<User>().getFinishedBook();
        totalBookCount = source.GetComponent<User>().getTotalBook();
        image.fillAmount = ((float)finishedBookCount / totalBookCount);
    }

    // Update is called once per frame
    void Update()
    {
        finishedBookCount = source.GetComponent<User>().getFinishedBook();
        totalBookCount = source.GetComponent<User>().getTotalBook();
        image.fillAmount = ((float)finishedBookCount / totalBookCount);
    }
}
