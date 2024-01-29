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

public class RegisterAccount : MonoBehaviour
{
    public TMP_InputField emailInput, usernameInput, passwordInput, passwordConfirmInput;
    public GameObject errorBox;
    public TextMeshProUGUI errorMsg;

    private DatabaseReference databaseReference;

    Firebase.Auth.FirebaseAuth auth;
    Firebase.Auth.FirebaseUser user;


   
    private void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://petminder-98607.firebaseio.com/");
        databaseReference = FirebaseDatabase.DefaultInstance.RootReference;

        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
        AuthStateChanged(this, null);

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

    private void OnDestroy()
    {
        auth.StateChanged -= AuthStateChanged;
        auth = null;
    }

    public void Register()
    {
        if (FirebaseAuth.DefaultInstance.CurrentUser != null)
        {
            FirebaseAuth.DefaultInstance.SignOut();
        }

        if (emailInput.text.Equals("") && passwordInput.text.Equals(""))
        {
            ShowErrorMsg("Please enter an email and password to register");
            return;
        }

        if (!passwordConfirmInput.text.Equals(passwordInput.text))
        {
            ShowErrorMsg("Reconfirm your password");
            return;
        }

        FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(emailInput.text,
            passwordInput.text).ContinueWithOnMainThread((task => 
            {
                if (task.IsCanceled)
                {
                    Firebase.FirebaseException e =
                    task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                    GetFirebaseError((AuthError)e.ErrorCode);
                    print("Registration Failed");
                    return;
                }
                if (task.IsFaulted)
                {
                    Firebase.FirebaseException e =
                    task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                    GetFirebaseError((AuthError)e.ErrorCode);
                    print("Registration Failed");
                    return;
                }

                 if (task.IsCompleted)
                {
                    print("Registration Complete");
                    signIn(emailInput.text, passwordInput.text);
                }

            }));
    }



    public void signIn(string email, string psWord) 
    {
        FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(email,psWord).ContinueWithOnMainThread((task =>
        {
            if (task.IsCanceled)
            {

                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetFirebaseError((AuthError)e.ErrorCode);

                return;
            }

            if (task.IsFaulted)
            {
                Firebase.FirebaseException e = task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;
                GetFirebaseError((AuthError)e.ErrorCode);
                return;
            }

            if (task.IsCompleted)
            {
                createPlayer(auth.CurrentUser.UserId.ToString(), usernameInput.text, psWord);
            }

        }));
    }

    public void createPlayer(string usrID, string usrName, string usrPassword)
    {


        User u = new User(usrName, usrPassword);
        string json = JsonUtility.ToJson(u);

        databaseReference.Child("users").Child(usrID).Child("userinfo").SetRawJsonValueAsync(json).ContinueWithOnMainThread((task =>
        {

            if (task.IsCanceled)
            {
                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetFirebaseError((AuthError)e.ErrorCode);
                print("Save Failed");
                return;
            }
            if (task.IsFaulted)
            {
                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetFirebaseError((AuthError)e.ErrorCode);
                print("Save Failed");
                return;
            }

            if (task.IsCompleted)
            {
                print("Save Complete");
                SceneManager.LoadScene(4);
            }

        }));

    }

    void GetFirebaseError(AuthError errorCode)
    {
        string msg = "";
        msg = errorCode.ToString();

        switch (errorCode)
        {
            case AuthError.AccountExistsWithDifferentCredentials:
                ShowErrorMsg("Account already exists with this email adress");
                break;

            case AuthError.MissingPassword:
                ShowErrorMsg("No inputted password");
                break;

            case AuthError.InvalidEmail:
                ShowErrorMsg("Invalid Email");
                break;
        }
    }

    IEnumerator ShowErrorMsg(string errMsg)
    {
        errorMsg.enabled = true;
        errorBox.SetActive(true);
        yield return new WaitForSeconds(3);
        errorMsg.enabled = false;
        errorBox.SetActive(false); ;
    }

}*/


