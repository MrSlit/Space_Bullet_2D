using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class siradakiseviye : MonoBehaviour
{
    public GameObject siradaki_level;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public timer kalan_süre;
    public GameObject holder;


    public void kazanmayi_goster()
    {
        siradaki_level.SetActive(true);
        holder.SetActive(true);
        Invoke("durdur", 1.0f);
    }


    void durdur()
    {
        Time.timeScale = 0.0f;
    }

    public void siradaki_seviye()
    {
        Time.timeScale = 1.0f;
      
    }

    public void ana_menu()
    {
        SceneManager.LoadScene("Scenes/ana_menu");
    }

    public void starsGained()
    {
        if (kalan_süre.timeValue >= 40)
        {
            star3.SetActive(true);
        }

        if (kalan_süre.timeValue < 40 && kalan_süre.timeValue >= 20)
        {
            star2.SetActive(true);
        }

        else
        {
            star1.SetActive(true);
        }
    }
}
