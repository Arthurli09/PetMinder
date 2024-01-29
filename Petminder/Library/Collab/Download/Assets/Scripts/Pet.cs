using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet
{
    int experience;
    int cons;
    int cap;
    string pName;
    string look;
    string birthday;
    public Pet(int exp, string name, string look, string date)
    {
        experience = exp;
        cons = 10;
        cap = 10;
        pName = name;
        this.look = look;
        birthday = date;
    }

    public int getExp(){
        return experience;
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

    public void increExp(int amount){
        experience += amount;
    }

    public void changeName(string name){
        pName = name;
    }

    public void changeLook(string suitName){
        look = suitName;
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
