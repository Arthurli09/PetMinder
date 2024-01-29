using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using Firebase;
//using Firebase.Auth;
//using Firebase.Database;
//using Firebase.Unity.Editor;
//using Firebase.Extensions;
[Serializable]
public class User : MonoBehaviour
{
    public int money;
    public int experience;
    public int lvl;
    public int curPet;
    public int cons;
    public int cap;
    public int finishedBook;
    public int curBookID;
    public int curChallengeID;


    public string usrName;
    public string usrPassword;
    public string profilePic;
    private string userID;

    List<Pet> pets;
    public List<Book> books;
    List<Challenge> challenges;
    List<Dictionary<string, string>> petStates;
    List<int> oneTimeItems;
    bool anyChallengeComplete;

    //Firebase.Auth.FirebaseAuth auth;
    //Firebase.Auth.FirebaseUser user;
    //private DatabaseReference databaseReference;
    private string usrID;

    public User(string usrName, string usrPassword)
    {
        this.usrName = usrName;
        this.usrPassword = usrPassword;
        this.money = 0;
        this.experience = 0;
        this.lvl = 0;
        this.curPet = 0;
        this.cons = 0;
        this.cap = 0;
        this.finishedBook = 0;
        this.curBookID = 0;
        this.curChallengeID = 0;
    }


    void Awake()
    {
        //FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://petminder-98607.firebaseio.com/");
        //databaseReference = FirebaseDatabase.DefaultInstance.RootReference;

        //auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        //user = auth.CurrentUser;
        //usrID = user.UserId;

        // using firebase database to load everything about the user in the awake function.

        /*FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("money").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }
 
                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    money = (int)snapshot.Value;
                }
            });

        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("experience").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    experience = (int)snapshot.Value;
                }
            });

        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("lvl").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    lvl = (int)snapshot.Value;
                }
            });

        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("usrName").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    usrName = (string)snapshot.Value;
                }
            });

        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("curPet").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    curPet = (int)snapshot.Value;
                }
            });

        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("cons").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    cons = (int)snapshot.Value;
                }
            });

        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("cap").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    cap = (int)snapshot.Value;
                }
            });


        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("finishedBook").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    finishedBook = (int)snapshot.Value;
                }
            });

        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("curBookID").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    curBookID = (int)snapshot.Value;
                }
            });

        FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("userInfo").Child("curChallengeID").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;
                    curChallengeID = (int)snapshot.Value;
                }
            });
        */
       
        profilePic = "Images/profilePic";
        pets = new List<Pet>();

        //load all books into the list 
        books = new List<Book>();

        /*FirebaseDatabase.DefaultInstance.GetReference("users").Child(usrID).Child("Books").GetValueAsync().
            ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted)
                {
                    print("load failed");
                }

                else if (task.IsCompleted)
                {
                    DataSnapshot snapshot = task.Result;

                    foreach (DataSnapshot ds in snapshot.Children)
                    {
                        int BookID = (int)ds.Value;
                        int pageAmount = (int)ds.Child("pageAmount").Value;
                        int pageProgress = (int)ds.Child("pageProgress").Value;
                        string title = (string)ds.Child("title").Value;
                        bool isArchived = (bool)ds.Child("isArchived").Value;
                        bool isFinished = (bool)ds.Child("isFinished").Value;
                        books.Add(new Book(BookID, pageAmount, pageProgress, title, isArchived, isFinished));
                    }
                }
            });
        */

        challenges = new List<Challenge>();
        petStates = new List<Dictionary<string, string>>();
        petStates.Add(new Dictionary<string, string>());
        petStates[0]["norm"] = "Image/slime";
        petStates[0]["happy"] = "Image/happy_slime";
        oneTimeItems = new List<int>();
        CreateDefault();
        anyChallengeComplete = false;
    }

    // This private function creates a default pet and two default books
    private void CreateDefault()
    {
        pets.Add(new Pet(0, 1, 1, "Slimy", "01/06/2020", "Images/slime", petStates));
        

        addOneTimeItem(0);
        addOneTimeItem(1);
        addOneTimeItem(100);

  
        for (int i = 0; i < challenges.Count; i++)
        {
            if (challenges[i].GetStatus() == true)
            {
                anyChallengeComplete = true;
                break;
            }
        }
    }

    
    public bool getChallengeNotif()
    {
        return anyChallengeComplete;
    }

    public int getExp(){
        return experience;
    }

    public int getPet(){
        return curPet;
    }

    public int getMoney(){
        return money;
    }

    public int getLvl(){
        return lvl;
    }

    public int getConst(){
        return cons;
    }

    public int getLvlCap(){
        return cap;
    }

    public int getFinishedBook()
    {
        return finishedBook;
    }

    public int getTotalBook()
    {
        return this.books.Count;
    }

    public string getName(){
        return usrName;
    }

    public string getProfilePic(){
        return profilePic;
    }

    public List<Pet> getPets(){
        return pets;
    }

    public List<Book> getBooks()
    {
        return books;
    }

    public List<Challenge> getChallenges() 
    {
        return challenges;   
    }

    public List<int> getOneTimeItems(){
        return oneTimeItems;
    }

    public void increExp(int amount){
        experience += amount;

        //databaseReference.Child("users").Child(userID).Child("experience").SetValueAsync(experience);

    }

    public void increMoney(int amount){
        money += amount;

        //databaseReference.Child("users").Child(userID).Child("money").SetValueAsync(money);
    }

    public void increLvl(){
        lvl++;

        //databaseReference.Child("users").Child(userID).Child("lvl").SetValueAsync(lvl);
    }

    public void changeName(string name){
        usrName = name;
    }

    public void changePet(int num){
        if(num < pets.Count && num >= 0){
            curPet = num;
        }
        else{
            Debug.Log("No such pet.");
        }
    }

    public void changPic(string newPic){
       profilePic = newPic;
    }

    public void addPet(int exp, int lvl, int look, string name, string date, string pic, List<Dictionary<string, string> > states){
        pets.Add(new Pet(exp, lvl, look, name, date, pic, states));
    }

    public void addOneTimeItem(int ID){
        oneTimeItems.Add(ID);
    }

    public int addBookReturnID(int pageAmount, string title)
    {
        Book b = new Book(curBookID++, pageAmount, title, false);
        books.Add(b);
        string json = JsonUtility.ToJson(b);

        /*databaseReference.Child("users").Child(usrID).Child("Books").Child(curBookID.ToString()).SetRawJsonValueAsync(json).ContinueWithOnMainThread((task =>
        {

            if (task.IsCanceled)
            { 

            }

            else if (task.IsFaulted)
            {
                
            }

            else if (task.IsCompleted)
            {
            }

        }));
        */
        return curBookID - 1;
    }

    public void deleteBook(int bookID)
    {
        for (int i=0; i<books.Count; i++)
        {
            if (books[i].GetBookID() == bookID)
            {
                if (books[i].GetPageAmount() == books[i].GetPageProgress())
                {
                    finishedBook--;
                }
                books.RemoveAt(i);
                break;
            }
        }

        //find the book in the database and delete it 
        /*databaseReference.Child("users").Child(usrID).Child("Books").Child(bookID.ToString()).RemoveValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCanceled)
            {

            }
            else if (task.IsFaulted)
            {

            }
            else if (task.IsCompleted)
            {

            }
        });
        */
    }

    /*public void UpdateBookProgress(int bookID, int incre)
    {
        bool before;

        for (int i = 0; i < books.Count; i++) {
            if (books[i].GetBookID() == bookID)
            {
                before = books[i].GetStatus();
                if (books[i].ChangePageProgress(incre))
                {
                    databaseReference.Child("users").Child(usrID).Child("Books").Child(bookID.ToString()).Child("isFinished").SetValueAsync(true).ContinueWithOnMainThread(task =>
                    {
                        if (task.IsCanceled)
                        {

                        }
                        else if (task.IsFaulted)
                        {

                        }
                        else if (task.IsCompleted)
                        {

                        }
                    });

                    databaseReference.Child("users").Child(usrID).Child("Books").Child(bookID.ToString()).Child("pageProgress").SetValueAsync(books[i].GetPageProgress()+incre).ContinueWithOnMainThread(task =>
                    {
                        if (task.IsCanceled)
                        {

                        }
                        else if (task.IsFaulted)
                        {

                        }
                        else if (task.IsCompleted)
                        {

                        }
                    });
                }
                else
                {
                    databaseReference.Child("users").Child(usrID).Child("Books").Child(bookID.ToString()).Child("pageProgress").SetValueAsync(books[i].GetPageProgress()+incre).ContinueWithOnMainThread(task =>
                    {
                        if (task.IsCanceled)
                        {

                        }
                        else if (task.IsFaulted)
                        {

                        }
                        else if (task.IsCompleted)
                        {

                        }
                    });
                }
               

                if (!before && books[i].GetStatus())
                {
                    finishedBook++;
                    databaseReference.Child("users").Child(usrID).Child("userInfo").Child("finishedBook").SetValueAsync(finishedBook).ContinueWithOnMainThread(task =>
                    {
                        if (task.IsCanceled)
                        {

                        }
                        else if (task.IsFaulted)
                        {

                        }
                        else if (task.IsCompleted)
                        {

                        }
                    });
                } 

                else if (before && !books[i].GetStatus())
                {
                    finishedBook--;
                    databaseReference.Child("users").Child(usrID).Child("userInfo").Child("finishedBook").SetValueAsync(finishedBook).ContinueWithOnMainThread(task =>
                    {
                        if (task.IsCanceled)
                        {

                        }
                        else if (task.IsFaulted)
                        {

                        }
                        else if (task.IsCompleted)
                        {

                        }
                    });
                }
            }
        }
    }*/


    public void addChallenge() { 
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
