using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCombat : MonoBehaviour
{
    public void Start()
    {
        GameObject.FindGameObjectWithTag("musicacombate").GetComponent<Music>().PlayMusic();
    }
}
