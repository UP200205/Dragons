using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    private Text txtLevel;
    private Text txtExperience;
    private LvlSystem lvlSystem;

   private void Awake(){
    txtLevel = transform.Find("txtLevel").GetComponent<Text>();
    txtExperience = transform.Find("txtExperience").GetComponent<Text>();
   }
   
   private void SetExperience(int Experience, int RequiredExperience){
    txtExperience.text = Experience + " / " + RequiredExperience;
   }

   private void SetLevelNumber(int levelNumber){
    txtLevel.text = ""+(levelNumber+1);
   }

   public void SetLevelSystem(LvlSystem lvlSystem){
    this.lvlSystem = lvlSystem;
    SetLevelNumber(lvlSystem.getLvlNumber());
    SetExperience(lvlSystem.getExperience(), lvlSystem.getRequiredExperience());
   }
}
