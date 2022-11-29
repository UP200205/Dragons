using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 

public class backBackground : MonoBehaviour
{
    public void LoadScene(string change)
    {
        SceneManager.LoadScene(change);
    }
}
