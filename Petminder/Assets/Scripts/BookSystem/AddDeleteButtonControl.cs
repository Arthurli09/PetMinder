using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddDeleteButtonControl : MonoBehaviour
{
    public GameObject source;

    // AddPanel objects
    public GameObject addPanel;
    public GameObject bookTitleInputField;
    public GameObject bookPageInputField;
    public Text bookTitleInput;
    public Text bookPageInputString;

    // DeletePanel objects
    public GameObject deletePanel;
    public Text fillBookTitleText;

    void Start()
    {
        source = GameObject.Find("ContInfo");
    }

    public void OpenAddPanel()
    {
        addPanel.SetActive(true);
    }

    public void CloseAddPanel()
    {
        addPanel.SetActive(false);
    }

    public void AddBook()
    {
        int bookPageNumber;
        if (System.Int32.TryParse(bookPageInputString.text, out bookPageNumber)) {
            int bookID = source.GetComponent<User>().addBookReturnID(bookPageNumber, bookTitleInput.text);
            BookLayout.bookLayout.AddBookDisplay(bookID);

        }
        bookTitleInputField.GetComponent<InputField>().text = "";
        bookPageInputField.GetComponent<InputField>().text = "";

        addPanel.SetActive(false);
    }

    // Delete Panel Operations
    
    public void OpenDeletePanel()
    {
        deletePanel.SetActive(true);
        int deletedBookID = BookLayout.bookLayout.curSelectedBookID;

        for (int i=0; i<BookLayout.bookLayout.bookList.Count; i++)
        {
            if (BookLayout.bookLayout.bookList[i].GetBookID() == deletedBookID)
            {
                fillBookTitleText.text = BookLayout.bookLayout.bookList[i].GetTitle();
                break;
            }
        }
    }

    public void CloseDeletePanel()
    {
        deletePanel.SetActive(false);
    }

    public void DeleteBook()
    {
        int deletedBookID = BookLayout.bookLayout.curSelectedBookID;
        source.GetComponent<User>().deleteBook(deletedBookID);
        BookLayout.bookLayout.DeleteBookDisplay(deletedBookID);
        fillBookTitleText.text = "";
        deletePanel.SetActive(false);
    }

}
