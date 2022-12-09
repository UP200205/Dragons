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
    int currentAttack=100;

    private void Start(){
        StartCoroutine(SetupBattle());
    }

    public IEnumerator SetupBattle(){
        enemyUnit.Setup();
        playerUnit.Setup();
        playerHud.SetData(playerUnit.creature);
        enemyHud.SetData(enemyUnit.creature);

        yield return dialogBox.TypeDialog($"¡Combatirás contra un {enemyUnit.creature.creatureBase.Name} salvaje!");
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
        UpdateAction(100);
    }

    IEnumerator PerformPlayerAttack(){
                state = BattleState.Busy;
        bool isFainted = false;
        if(currentAttack==1){
            yield return dialogBox.TypeDialog($"{playerUnit.creature.creatureBase.Name} usó ataque 1");
            yield return new WaitForSeconds(1f);
            isFainted = enemyUnit.creature.TakeDamage(playerUnit.creature.Passive1,playerUnit.creature);
        }else if(currentAttack==2){
            yield return dialogBox.TypeDialog($"{playerUnit.creature.creatureBase.Name} usó ataque 2");
            yield return new WaitForSeconds(1f);
            isFainted = enemyUnit.creature.TakeDamage(playerUnit.creature.Passive2,playerUnit.creature);
        }else if(currentAttack==3){
            yield return dialogBox.TypeDialog($"{playerUnit.creature.creatureBase.Name} usó definitiva");
            yield return new WaitForSeconds(1f);
            isFainted = enemyUnit.creature.TakeDamage(playerUnit.creature.Ultimate,playerUnit.creature);
        }
        
        
        yield return enemyHud.UpdateHealth();
        UpdateAttack(100);
        if (isFainted){
            yield return dialogBox.TypeDialog($"{enemyUnit.creature.creatureBase.Name} ha fallecido");
        }else{
            StartCoroutine(PerformEnemyAttack());
        }
    }

    IEnumerator PerformEnemyAttack(){
        state = BattleState.EnemyMove;
        var enemyAttack = Random.Range(1,4);
       bool isFainted = false;
        if(enemyAttack==1){
            yield return dialogBox.TypeDialog($"{enemyUnit.creature.creatureBase.Name} usó ataque 1");
            yield return new WaitForSeconds(1f);
            isFainted = playerUnit.creature.TakeDamage(enemyUnit.creature.Passive1,enemyUnit.creature);
        }else if(enemyAttack==2){
            yield return dialogBox.TypeDialog($"{enemyUnit.creature.creatureBase.Name} usó ataque 2");
            yield return new WaitForSeconds(1f);
            isFainted = playerUnit.creature.TakeDamage(enemyUnit.creature.Passive2,enemyUnit.creature);
        }else if(enemyAttack==3){
            yield return dialogBox.TypeDialog($"{enemyUnit.creature.creatureBase.Name} usó definitiva");
            yield return new WaitForSeconds(1f);
            isFainted = playerUnit.creature.TakeDamage(enemyUnit.creature.Ultimate,enemyUnit.creature);
        }
        yield return playerHud.UpdateHealth();
          if (isFainted){
              yield return dialogBox.TypeDialog($"{playerUnit.creature.creatureBase.Name} ha fallecido");
          }else{
              PlayerAction();
          }

    }


    private void Update(){
        if(state==BattleState.PlayerAction){
            HandleActionSelection();
        }else if(state==BattleState.PlayerMove){
            HandleAttackSelection();
        }
    }

    void HandleActionSelection(){
        if(currentAction==0){
            PlayerMove();
        }else if(currentAction==1){

        }
    }

    void HandleAttackSelection(){
        if(currentAttack!=100){
            dialogBox.EnableAttackSelector(false);
            dialogBox.EnableDialogText(true);
            StartCoroutine(PerformPlayerAttack());
        }

        
    }

    public void UpdateAction(int action){
        currentAction=action;
    }

    public void UpdateAttack(int attack){
        currentAttack=attack;
    }
}
