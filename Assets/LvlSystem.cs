using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlSystem
{
    public int level;
    public int currentXp;
    public int requiredXp;

    public LvlSystem(){
        level=0;
        currentXp=0;
        requiredXp=100;
    }

    public void AddExperience(int amount){
        currentXp += amount;
        if(currentXp>=requiredXp){
            level++;
            currentXp-=requiredXp;
        }
    }

    public int getLvlNumber(){
        return level;
    }

    public int getExperience(){
        return currentXp;
    }

    public int getRequiredExperience(){
        return requiredXp;
    }
}
