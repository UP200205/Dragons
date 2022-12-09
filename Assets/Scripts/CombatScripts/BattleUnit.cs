using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] Creature cBase;
    [SerializeField] int level;
    [SerializeField] int rarity;

    public CreatureLvl creature {get; set;}

    public void Setup(){
        creature = new CreatureLvl(cBase, level, rarity);
        GetComponent<Image>().sprite = creature.creatureBase.MainSprite;
    }
}
