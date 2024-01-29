using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoInGame : MonoBehaviour
{
    public void toInGame()
    {
        SceneManager.LoadScene(7);
    }
}
