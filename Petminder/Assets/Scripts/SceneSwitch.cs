using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    int tempSceneNum;
    public void Switch(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }

    //use this function in combo with the WaitSwitch function
    //in order to wait and then switch scene 
    //(the button click only allows for functions with zero or one parameter)
    public void SetSwitch(int sceneNum){
        tempSceneNum = sceneNum;
    }

    public void WaitSwitch(int sec){
        StartCoroutine(wait((float)sec));
    }

    IEnumerator wait(float second){
        yield return new WaitForSeconds(second);
        SceneManager.LoadScene(tempSceneNum);
    }
}
