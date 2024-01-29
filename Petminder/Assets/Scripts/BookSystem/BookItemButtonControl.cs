using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookItemButtonControl : MonoBehaviour
{
    public GameObject source;
    public Text inputText;

    public int bookID;
    public int inputNumber;

    public void AddPages()
    {
        source = GameObject.Find("ContInfo");
        if (System.Int32.TryParse(inputText.text, out inputNumber))
        {
            //source.GetComponent<User>().UpdateBookProgress(bookID, inputNumber);
            BookLayout.bookLayout.UpdateBook(bookID);
        }
    }

    public void MinusPage()
    {
        source = GameObject.Find("ContInfo");
        if (System.Int32.TryParse(inputText.text, out inputNumber))
        {
            //source.GetComponent<User>().UpdateBookProgress(bookID, -inputNumber);
            BookLayout.bookLayout.UpdateBook(bookID);
        }
    }

    public void SelectPage()
    {
        BookLayout.bookLayout.preSelectedBookID = BookLayout.bookLayout.curSelectedBookID;
        BookLayout.bookLayout.curSelectedBookID = bookID;
        BookLayout.bookLayout.UpdateSelection();
    }
}
