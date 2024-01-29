using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Firebase.Auth;
using UnityEngine.UI;
using TMPro;

public class Login_GoToHomeScreen : MonoBehaviour
{
    public TextMeshProUGUI emailInput, passwordInput;


    public void Login() {

        /*FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordASync(emailInput.text, passwordInput.text).ContinueWith((task =>
        {

            if (task.IsCanceled)
            {
                return;
            }

            if (task.IsFaulted)
            {
                Firebase.FirebaseException e =
                task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;

                GetErrorMessage((AuthError)e.ErrorCode);
                return;
            }

            if (task.IsCompleted)
            {
                print("User is LOGGED IN");
                SceneManager.LoadScene(3);

            }

        }));

        */
    }


    
}
