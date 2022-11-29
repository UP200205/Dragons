using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusciShop : MonoBehaviour
{
  public void Start()
    {
        GameObject.FindGameObjectWithTag("musica").GetComponent<Music>().PlayMusic();
    }
}
