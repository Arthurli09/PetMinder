using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Book : MonoBehaviour
{
    public int bookID;
    public int pageAmount;
    public int pageProgress;
    public string title;
    public bool isFinished;
    public bool isArchived;

    public Book()
    {

    }
    public Book(int bookID, int pageAmount, string title, bool isArchived)
    {
        this.bookID = bookID; 
        this.pageAmount = pageAmount;
        this.pageProgress = 0;
        this.title = title;
        this.isArchived = isArchived;
        this.isFinished = false;
    }
    public Book(int BookID, int pageAmount, int pageProgress,string title, bool isArchived, bool isFinished)
    {
        this.bookID = bookID;
        this.pageAmount = pageAmount;
        this.pageProgress = pageProgress;
        this.title = title;
        this.isArchived = isArchived;
        this.isFinished = isFinished;
    }

    public int GetBookID()
    {
        return bookID;
    }

    public int GetPageAmount()
    {
        return pageAmount;
    }

    public int GetPageProgress()
    {
        return pageProgress;
    }

    public string GetTitle()
    {
        return title;
    }

    public bool GetStatus()
    {
        return isFinished;
    }

    public bool GetIsArchived()
    {
        return isArchived;
    }

    public void ChangeStatus(bool v)
    {
        isFinished = v;
    }

    public void ChangeIsArchived(bool v)
    {
        isArchived = v;
    }

    // Changes the page number
    public bool ChangePageProgress(int change)
    {
        pageProgress += change;
        pageProgress = Mathf.Max(pageProgress, 0);
        pageProgress = Mathf.Min(pageProgress, pageAmount);

        if (pageAmount == pageProgress)
        {
            isFinished = true;
        } else
        {
            isFinished = false;
        }
        return isFinished;
    }
}
