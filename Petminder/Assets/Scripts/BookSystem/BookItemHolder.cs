using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BookItemHolder : MonoBehaviour
{
    public TextMeshProUGUI bookTitle;
    public TextMeshProUGUI progressNumber;
    public int bookID;
    public int pageAmount;
    public int pageProgress;
    public Image progressBar;
    public GameObject bookFrame;
    public GameObject plusButton;
    public GameObject minusButton;
}
