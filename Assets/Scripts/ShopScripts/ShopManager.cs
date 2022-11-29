using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{   
    public Text TxtMoney;
    public int money;
    public ShopUI[] shopPanel;
    public Creature[] shopCreature;

    void Start(){
        money=10;
        TxtMoney.text = money.ToString();
        LoadPanels();

    }

    public void LoadPanels(){
        for(int i=0;i<shopCreature.Length; i++){
            shopPanel[i].TxtTitle.text = shopCreature[i].Name;
            shopPanel[i].TxtDescription.text = shopCreature[i].Description;
            shopPanel[i].TxtElement.text = shopCreature[i].ElementType.ToString();
            shopPanel[i].TxtCost.text = "$"+shopCreature[i].Cost.ToString();
            shopPanel[i].ImgCreature.sprite = shopCreature[i].MainSprite;
            shopPanel[i].ImgElement.sprite = shopCreature[i].ElementSprite;
        }
    }



    

    
}
