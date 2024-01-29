using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet
{
    int experience;
    int lvl;
    int cons;
    int cap;
    int look;
    string pName;
    string birthday;
    string pic;
    List<Dictionary<string, string> > states;

    public Pet(int exp, int lvl, int look, string name, string date, string profilePic, List<Dictionary<string, string> > states)
    {
        experience = exp;
        this.lvl = lvl;
        cons = 10;
        cap = 10;
        pName = name;
        this.look = look;
        birthday = date;
        pic = profilePic;
        this.states = states;
    }

    public int getExp(){
        return experience;
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

    public string getName(){
        return pName;
    }

    public string getBDay(){
        return birthday;
    }

    public string getPic(){
        return pic;
    }

    public void increExp(int amount){
        experience += amount;
    }

    public void increLvl(){
        lvl++;
    }

    public void changeName(string name){
        pName = name;
    }

    public void changeLook(int suitNum){
        look = suitNum;
    }
   
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
