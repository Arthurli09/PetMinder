using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public string Username;
    public string Password;

    public Player()
    {

    }

    public Player(string Username, string Password)
    {
        this.Username = Username;
        this.Password = Password;
    }

}
