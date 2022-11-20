using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureLvl
{
    Creature creatureBase;
   int level;
   int rarity;

   public CreatureLvl(Creature cBase, int cLevel, int cRarity){
    creatureBase = cBase;
    level = cLevel;
    rarity = cRarity;
   }

   public int Attack{
    get{return Mathf.FloorToInt((creatureBase.Attack*level)/100f)+5;}
   }

   public int Life{
    get{return Mathf.FloorToInt((creatureBase.Life*level)/100f)+5;}
   }

   public int Defense{
    get{return Mathf.FloorToInt((creatureBase.Defense*level)/100f)+5;}
   }

   public int Passive1{
    get{return Mathf.FloorToInt((creatureBase.Passive1*level)/100f)+5;}
   }

   public int Passive2{
    get{return Mathf.FloorToInt((creatureBase.Passive2*level)/100f)+5;}
   }

   public int Ultimate{
    get{return Mathf.FloorToInt((creatureBase.Ultimate*level)/100f)+5;}
   }
}
