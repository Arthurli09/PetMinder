/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Firebase;
using Firebase.Auth;
using Firebase.Extensions;
using Firebase.Database;
using Firebase.Unity.Editor;

public class SignIN : MonoBehaviour
{
    public TMP_InputField emailInput,passwordInput;
    public Canvas errorNotif;

    private DatabaseReference databaseReference;

    Firebase.Auth.FirebaseAuth auth;

    private void Start()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
    }

    public void Login()
    {
        if (auth.CurrentUser != null)
        {
            auth.SignOut();
        }

        auth.SignInWithEmailAndPasswordAsync(emailInput.text, passwordInput.text).ContinueWithOnMainThread((task =>
        {
            if (task.IsCanceled)
            {

                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetErrorMessage((AuthError)e.ErrorCode);

                return;
            }

            if (task.IsFaulted)
            {
                Firebase.FirebaseException e = task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;
                GetErrorMessage((AuthError)e.ErrorCode);
                return;
            }

            if (task.IsCompleted)
            {
                print("User is Logged In");
                SceneManager.LoadScene(4);
            }
        }));
    }
    void GetErrorMessage(AuthError errorCode)
    {
        string msg = "";
        msg = errorCode.ToString();

        switch (errorCode)
        {

            case AuthError.AccountExistsWithDifferentCredentials:
                print("Account Exists");
                break;

            case AuthError.MissingPassword:
                print("No Password");
                break;
            case AuthError.WrongPassword:
                print("Wrong Password");
                break;
            case AuthError.InvalidEmail:
                print("Invalid Email");
                break;
        }
        print(msg);
    }


}*/
