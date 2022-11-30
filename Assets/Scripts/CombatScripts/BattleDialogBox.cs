using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleDialogBox : MonoBehaviour
{
   [SerializeField] int lettersPerSecond;

   [SerializeField] TextMeshProUGUI txtDialog;
   [SerializeField] GameObject attackSelector;
   [SerializeField] GameObject actionSelector;
   
   [SerializeField] List<TextMeshProUGUI> actionTexts;
   [SerializeField] List<TextMeshProUGUI> attackTexts;

   public void SetDialog(string dialog){
      txtDialog.text = dialog;
   }

   public IEnumerator TypeDialog(string dialog){
      txtDialog.text="";
      foreach(var letter in dialog.ToCharArray()){
         txtDialog.text+=letter;
         yield return new WaitForSeconds(1f/lettersPerSecond);
      }
   }



   public void EnableDialogText(bool enabled){
      txtDialog.enabled = enabled;
   }

   public void EnableActionSelector(bool enabled){
      actionSelector.SetActive(enabled);
   }

   public void EnableAttackSelector(bool enabled){
      attackSelector.SetActive(enabled);
   }
}
