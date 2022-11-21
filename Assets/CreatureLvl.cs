using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureLvl
{
    Creature creatureBase;
   int level;
   float rarity;

   public CreatureLvl(Creature cBase, int cLevel, float cRarity){
    creatureBase = cBase;
    level = cLevel;
    rarity = cRarity;
   }

   public int Attack{
    get{return Mathf.FloorToInt((creatureBase.Attack*level*(1+rarity))/100f)+5;}
   }

   public int Life{
    get{return Mathf.FloorToInt((creatureBase.Life*level*(1+rarity))/100f)+5;}
   }

   public int Defense{
    get{return Mathf.FloorToInt((creatureBase.Defense*level*(1+rarity))/100f)+5;}
   }

   public int Passive1{
    get{return Mathf.FloorToInt((creatureBase.Passive1*level*(1+rarity))/100f)+5;}
   }

   public int Passive2{
    get{return Mathf.FloorToInt((creatureBase.Passive2*level*(1+rarity))/100f)+5;}
   }

   public int Ultimate{
    get{return Mathf.FloorToInt((creatureBase.Ultimate*level*(1+rarity))/100f)+5;}
   }
}
