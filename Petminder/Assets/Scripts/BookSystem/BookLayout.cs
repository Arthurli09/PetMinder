using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookLayout : MonoBehaviour
{
    public static BookLayout bookLayout;

    public GameObject source;
    public GameObject itemHolderPrefab;
    public Transform grid;

    public List<Book> bookList;
    public List<GameObject> holderList;

    public int curSelectedBookID;
    public int preSelectedBookID;

    void Start()
    {
        source = GameObject.Find("ContInfo");
        bookLayout = this;
        holderList = new List<GameObject>();

        // Passed by reference, if User updates, then bookList updates
        bookList = source.GetComponent<User>().getBooks();
        FillList();
    }

    public void FillList()
    {
        for (int i = 0; i < bookList.Count; i++)
        {
            // Only process the not-archived books
            if (bookList[i].GetIsArchived())
            {
                continue;
            }

            // Begin processing and displaying the book
            GameObject holder = Instantiate(itemHolderPrefab, grid, false);
            BookItemHolder holderScript = holder.GetComponent<BookItemHolder>();

            // Fills in information for the book items
            holderScript.bookTitle.text = bookList[i].GetTitle();
            holderScript.bookID = bookList[i].GetBookID();
            holderScript.pageAmount = bookList[i].GetPageAmount();
            holderScript.pageProgress = bookList[i].GetPageProgress();
            holderScript.progressNumber.text = bookList[i].GetPageProgress() + "/" + bookList[i].GetPageAmount();
            holderScript.progressBar.fillAmount = ((float)bookList[i].GetPageProgress()/bookList[i].GetPageAmount());

            // Setting ID for Buttons
            holderScript.GetComponent<BookItemButtonControl>().bookID = bookList[i].GetBookID();

            // Add the itemholders to the list
            holderList.Add(holder);

            if (i == 0)
            {
                curSelectedBookID = bookList[i].GetBookID();
                preSelectedBookID = bookList[i].GetBookID();
                UpdateSelection();
            }
        }   
    }

    public void UpdateBook(int bookID)
    {
        for (int i=0; i<holderList.Count; i++)
        {
            BookItemHolder holderScript = holderList[i].GetComponent<BookItemHolder>();
            if (holderScript.bookID == bookID)
            {
                holderScript.progressNumber.text = bookList[i].GetPageProgress() + "/" + bookList[i].GetPageAmount();
                holderScript.progressBar.fillAmount = ((float)bookList[i].GetPageProgress() / bookList[i].GetPageAmount());
                break;
            }
        }
    }

    public void AddBookDisplay(int bookID)
    {
        for (int i=0; i<bookList.Count; i++)
        {
            if (bookList[i].GetBookID() == bookID)
            {
                GameObject holder = Instantiate(itemHolderPrefab, grid, false);
                BookItemHolder holderScript = holder.GetComponent<BookItemHolder>();

                // Fills in information for the book items
                holderScript.bookTitle.text = bookList[i].GetTitle();
                holderScript.bookID = bookList[i].GetBookID();
                holderScript.pageAmount = bookList[i].GetPageAmount();
                holderScript.pageProgress = bookList[i].GetPageProgress();
                holderScript.progressNumber.text = bookList[i].GetPageProgress() + "/" + bookList[i].GetPageAmount();
                holderScript.progressBar.fillAmount = ((float)bookList[i].GetPageProgress() / bookList[i].GetPageAmount());

                // Setting ID for Buttons
                holderScript.GetComponent<BookItemButtonControl>().bookID = bookList[i].GetBookID();

                // Add the itemholders to the list
                holderList.Add(holder);

                // Put the select on the new book
                preSelectedBookID = curSelectedBookID;
                curSelectedBookID = bookList[i].GetBookID();
                UpdateSelection();

                break;
            }
        }
    }

    public void DeleteBookDisplay(int bookID)
    {
        for (int i=0; i<holderList.Count; i++)
        {
            BookItemHolder holderScript = holderList[i].GetComponent<BookItemHolder>();
            if (holderScript.bookID == bookID)
            {
                GameObject temp = holderList[i];
                holderList.RemoveAt(i);
                Destroy(temp);
                break;
            }
        }

        if (bookList.Count >= 1)
        {         
            curSelectedBookID = bookList[0].GetBookID();
            preSelectedBookID = bookList[0].GetBookID();
            UpdateSelection();
        }
    }

    public void UpdateSelection()
    {
        for (int i=0; i<holderList.Count; i++)
        {
            BookItemHolder holderScript = holderList[i].GetComponent<BookItemHolder>();

            if (holderScript.bookID == curSelectedBookID)
            {
                holderScript.bookFrame.GetComponent<Image>().color = new Color32(255, 165, 0, 255);
            } else if (holderScript.bookID == preSelectedBookID)
            {
                holderScript.bookFrame.GetComponent<Image>().color = new Color32(165, 165, 255, 255);
            }
        }
    }

}
