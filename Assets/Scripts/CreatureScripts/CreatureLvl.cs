using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureLvl
{
   public Creature creatureBase {get; set; }
   public int Level {get; set; }
   public int Rarity {get; set; }
   public int Health {get; set; }

   public CreatureLvl(Creature cBase, int cLevel, int cRarity){
    creatureBase = cBase;
    Level = cLevel;
    Rarity = cRarity;
    Health = Life;
    
   }

   public int Attack{
    get{return Mathf.FloorToInt((creatureBase.Attack*Level+(5*Rarity))/100f)+5;}
   }

   public int Life{
    get{return Mathf.FloorToInt((creatureBase.Life*Level+(5*Rarity))/100f)+5;}
   }

   public int Defense{
    get{return Mathf.FloorToInt((creatureBase.Defense*Level+(5*Rarity))/100f)+5;}
   }

   public int Passive1{
    get{return Mathf.FloorToInt((creatureBase.Passive1*Level+(5*Rarity))/100f)+5;}
   }

   public int Passive2{
    get{return Mathf.FloorToInt((creatureBase.Passive2*Level+(5*Rarity))/100f)+5;}
   }

   public int Ultimate{
    get{return Mathf.FloorToInt((creatureBase.Ultimate*Level+(5*Rarity))/100f)+5;}
   }

   public bool TakeDamage(int move,CreatureLvl attacker){
    float modifiers = Random.Range(0.85f, 1f);
    float a = (2 * attacker.Level +(5* attacker.Rarity )+ 10) / 250f;
    float d = a * move * ((float)attacker.Attack / Defense) + 2;
    int damage = Mathf.FloorToInt(d * modifiers);

    Health -= damage;
    if(Health <= 0){
      Health = 0;
      return true;
    }
    return false;
   }

}
