using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArchiveLayout : MonoBehaviour
{
    public static ArchiveLayout archiveLayout;

    public GameObject source;
    public GameObject itemHolderPrefab;
    public Transform grid;

    public List<Book> bookList;
    public List<GameObject> holderList;

    void Start()
    {
        archiveLayout = this;
        holderList = new List<GameObject>();

        // Linked the list to the list of books that's in User
        source = GameObject.Find("ContInfo");
        // Passed by reference, if User updates, then bookList updates
        bookList = source.GetComponent<User>().getBooks();
        FillList();
    }

    public void FillList()
    {
        for (int i = 0; i < bookList.Count; i++)
        {
            // Only process the archived books
            if (!bookList[i].GetIsArchived())
            {
                continue;
            }

            // Begin processing and displaying the book
            GameObject holder = Instantiate(itemHolderPrefab, grid, false);
            ArchiveItemHolder holderScript = holder.GetComponent<ArchiveItemHolder>();

            // Fills in information for the book items
            holderScript.bookTitle.text = bookList[i].GetTitle();
            holderScript.bookID = bookList[i].GetBookID();
            holderScript.pageAmount = bookList[i].GetPageAmount();
            holderScript.pageProgress = bookList[i].GetPageProgress();
            holderScript.pageDisplayText.text = bookList[i].GetPageProgress() + "/" + bookList[i].GetPageAmount();

            // Setting ID for Buttons
            holderScript.GetComponent<ArchiveItemButtonControl>().bookID = bookList[i].GetBookID();

            // Add the itemholders to the list
            holderList.Add(holder);
        }
    }

    public void AddBookDisplay(int bookID)
    {
        for (int i = 0; i < bookList.Count; i++)
        {
            if (bookList[i].GetBookID() == bookID)
            {
                GameObject holder = Instantiate(itemHolderPrefab, grid, false);
                ArchiveItemHolder holderScript = holder.GetComponent<ArchiveItemHolder>();

                // Fills in information for the book items
                holderScript.bookTitle.text = bookList[i].GetTitle();
                holderScript.bookID = bookList[i].GetBookID();
                holderScript.pageAmount = bookList[i].GetPageAmount();
                holderScript.pageProgress = bookList[i].GetPageProgress();
                holderScript.pageDisplayText.text = bookList[i].GetPageProgress() + "/" + bookList[i].GetPageAmount();

                // Setting ID for Buttons
                holderScript.GetComponent<ArchiveItemButtonControl>().bookID = bookList[i].GetBookID();

                // Add the itemholders to the list
                holderList.Add(holder);

                break;
            }
        }
    }

    public void DeleteBookDisplay(int bookID)
    {
        for (int i = 0; i < holderList.Count; i++)
        {
            ArchiveItemHolder holderScript = holderList[i].GetComponent<ArchiveItemHolder>();
            if (holderScript.bookID == bookID)
            {
                GameObject temp = holderList[i];
                holderList.RemoveAt(i);
                Destroy(temp);
                break;
            }
        }
    }


}
