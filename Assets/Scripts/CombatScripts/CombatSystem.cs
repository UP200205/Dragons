using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState{Start,PlayerAction,PlayerMove,EnemyMove,Busy}

public class CombatSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD playerHud;
    [SerializeField] BattleHUD enemyHud;
    [SerializeField] BattleDialogBox dialogBox;

    BattleState state;
    int currentAction=100;

    private void Start(){
        StartCoroutine(SetupBattle());
    }

    public IEnumerator SetupBattle(){
        enemyUnit.Setup();
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHud.SetData(playerUnit.Creature);
        enemyHud.SetData(enemyUnit.Creature);

        yield return dialogBox.TypeDialog($"¡Combatirás contra un {enemyUnit.Creature.creatureBase.Name} salvaje!");
        yield return new WaitForSeconds(1f);

        PlayerAction();
    }

    void PlayerAction(){
        state=BattleState.PlayerAction;
        StartCoroutine(dialogBox.TypeDialog("Elige una acción."));
        dialogBox.EnableActionSelector(true);
    }

    void PlayerMove(){
        state = BattleState.PlayerMove;
        dialogBox.EnableActionSelector(false);
        dialogBox.EnableDialogText(false);
        dialogBox.EnableAttackSelector(true);
    }

    private void Update(){
        if(state==BattleState.PlayerAction){
            HandleActionSelection();
        }
    }

    void HandleActionSelection(){
        if(currentAction==0){
            PlayerMove();
        }else if(currentAction==1){

        }
    }

    public void UpdateAction(int action){
        currentAction=action;
    }
}
