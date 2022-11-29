using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] Creature cBase;
    [SerializeField] int level;
    [SerializeField] float rarity;

    public CreatureLvl Creature {get; set;}

    public void Setup(){
        Creature = new CreatureLvl(cBase, level, rarity);
        GetComponent<Image>().sprite = Creature.creatureBase.MainSprite;
    }
}
