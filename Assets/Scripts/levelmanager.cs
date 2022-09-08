using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class levelmanager : MonoBehaviour
{

    public static int dusmanSayisi = 0;
    public int level;
  

    public void OpenScene ()
    {
        SceneManager.LoadScene("Level " + level.ToString());
    }


}
