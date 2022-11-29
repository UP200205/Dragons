using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureLvl
{
   public Creature creatureBase {get; set; }
   public int Level {get; set; }
   public float rarity {get; set; }
   public int Health {get; set; }

   public CreatureLvl(Creature cBase, int cLevel, float cRarity){
    creatureBase = cBase;
    Level = cLevel;
    rarity = cRarity;
    Health = Life;
    
   }

   public int Attack{
    get{return Mathf.FloorToInt((creatureBase.Attack*Level*(1+rarity))/100f)+5;}
   }

   public int Life{
    get{return Mathf.FloorToInt((creatureBase.Life*Level*(1+rarity))/100f)+5;}
   }

   public int Defense{
    get{return Mathf.FloorToInt((creatureBase.Defense*Level*(1+rarity))/100f)+5;}
   }

   public int Passive1{
    get{return Mathf.FloorToInt((creatureBase.Passive1*Level*(1+rarity))/100f)+5;}
   }

   public int Passive2{
    get{return Mathf.FloorToInt((creatureBase.Passive2*Level*(1+rarity))/100f)+5;}
   }

   public int Ultimate{
    get{return Mathf.FloorToInt((creatureBase.Ultimate*Level*(1+rarity))/100f)+5;}
   }
}
