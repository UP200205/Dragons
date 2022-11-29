using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtName;
    [SerializeField] TextMeshProUGUI txtLevel;
    [SerializeField] HPBar hpBar;

    public void SetData(CreatureLvl creature){
        txtName.text = creature.creatureBase.Name;
        txtLevel.text = "Lvl "+creature.Level;
        hpBar.SetHP((float)creature.Health/creature.Life);
    }
}
