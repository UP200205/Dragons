using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleHUD playerHud;

    private void Start(){
        SetupBattle();
    }

    public void SetupBattle(){
        playerUnit.Setup();
        playerHud.SetData(playerUnit.Creature);
    }
}
