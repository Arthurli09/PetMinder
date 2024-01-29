using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FillTopBookCount : MonoBehaviour
{
    GameObject source;
    public TextMeshProUGUI fillText;

    int totalBookCount;
    int finishedBookCount;

    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.Find("ContInfo");
        finishedBookCount = source.GetComponent<User>().getFinishedBook();
        totalBookCount = source.GetComponent<User>().getTotalBook();
        fillText.text = finishedBookCount.ToString() + "/" + totalBookCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        finishedBookCount = source.GetComponent<User>().getFinishedBook();
        totalBookCount = source.GetComponent<User>().getTotalBook();
        fillText.text = finishedBookCount.ToString() + "/" + totalBookCount.ToString();
    }
}
