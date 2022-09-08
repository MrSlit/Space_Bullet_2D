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
    public GameObject tamamenbitti;


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
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            tamamenbitti.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
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
            star2.SetActive(false);
            star1.SetActive(false);
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
