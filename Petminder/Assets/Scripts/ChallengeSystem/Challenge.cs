using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Challenge
{
    public int curChallengeID;
    public string title;
    public string description;
    public bool isCompleted;
    public string currReward;

    public Challenge(int curChallengeID, string title, string description, bool isCompleted, string currReward) {
        this.curChallengeID = curChallengeID;
        this.title = title;
        this.description = description;
        this.isCompleted = isCompleted;
        this.currReward = currReward;
    }
    public string GetReward()
    {
        return currReward;
    }
    public int getChallengeID()
    {
        return curChallengeID;
    }
    public string GetDescription()
    {
        return description;
    }

    public string GetTitle()
    {
        return title;
    }

    public bool GetStatus()
    {
        return isCompleted;
    }

 
  
}
