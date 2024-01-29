/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Extensions;
using Firebase;
using Firebase.Unity.Editor;

public class TestingObjectSave : MonoBehaviour
{
    private DatabaseReference databaseReference;

    Firebase.Auth.FirebaseAuth auth;
    Firebase.Auth.FirebaseUser user;
    private string usrID;
    // Start is called before the first frame update
    void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://petminder-98607.firebaseio.com/");
        databaseReference = FirebaseDatabase.DefaultInstance.RootReference;

        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
        AuthStateChanged(this, null);

        user = auth.CurrentUser;
        usrID = user.UserId;
    }

    void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {
        if (auth.CurrentUser != user)
        {
            bool signedIn = user != auth.CurrentUser && auth.CurrentUser != null;
            if (!signedIn && user != null)
            {
                Debug.Log("Signed Out" + user.UserId);
            }
            user = auth.CurrentUser;

            if (signedIn)
            {
                Debug.Log("Signed in" + user.UserId);
            }
        }
    }
    // Update is called once per frame
    public void testingSave()
    {
        User u = new User("vince", "bruh");
        string json = JsonUtility.ToJson(u);

        List<object> books = new List<object>();

        Book b = new Book(1, 200,"Default Harry Potter", false);
        string json2 = JsonUtility.ToJson(b);

        //string json2 = JsonUtility.ToJson(books);
        databaseReference.Child("users").Child(usrID).Child("userInfo").SetRawJsonValueAsync(json).ContinueWithOnMainThread((task =>
        {
            if (task.IsCanceled)
            {
              
                print("Save Failed");
                return;
            }
            if (task.IsFaulted)
            {
            
                print("Save Failed");
                return;
            }

            if (task.IsCompleted)
            {
                print("Save Complete userInfo");
                
            }
            
        }));

        databaseReference.Child("users").Child(usrID).Child("books").SetRawJsonValueAsync(json2).ContinueWithOnMainThread((task =>
        {
            if (task.IsCanceled)
            {

                print("Save Failed");
                return;
            }
            if (task.IsFaulted)
            {

                print("Save Failed");
                return;
            }

            if (task.IsCompleted)
            {
                print("Save Complete books");

            }

        }));
    }

  
}*/
