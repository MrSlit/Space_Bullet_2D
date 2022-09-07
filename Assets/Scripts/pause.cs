using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject durdurmenu;
    public GameObject pausebutton;
    public void paneli_goster()
    {
        durdurmenu.SetActive(true);
        Invoke("durdur", 0.0f);
    }


    void durdur()
    {
        Time.timeScale = 0.0f;
    }

    public void tekraroyna()
    {
        Application.LoadLevel(Application.loadedLevel);
        durdurmenu.SetActive(false);
        Time.timeScale = 1.0f;

    }
    public void ana_menu()
    {
        SceneManager.LoadScene("Scenes/ana_menu");
        durdurmenu.SetActive(false);
        Time.timeScale = 1.0f;

    }

    public void geridon()
    {         
        Time.timeScale = 1.0f;
        durdurmenu.SetActive(false);
        
    }

}
