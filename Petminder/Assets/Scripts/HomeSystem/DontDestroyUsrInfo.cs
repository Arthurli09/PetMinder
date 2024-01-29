using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyUsrInfo : MonoBehaviour
{
    private static DontDestroyUsrInfo instance = null;
    public static DontDestroyUsrInfo Instance {
        get {
            return instance;
        }
    }
    
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else {
            instance = this;

        }

        DontDestroyOnLoad(this.gameObject);
    }
}
