using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusicShop : MonoBehaviour
{
    public void Start()
    {
        GameObject.FindGameObjectWithTag("musica").GetComponent<Music>().StopMusic();
    }
}
