using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject oyuncu;
    public Text timeText;
    public float timeValue = 60;
    public bitis bitti;
    public GameObject patlama;

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0) {
        timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            Destroy(oyuncu);
            bitti.paneli_goster();

  
        }

        DisplayTime(timeValue);
    }
    void DisplayTime(float timeToDisplay)
    {
       
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{00}", seconds);

       
    }
}
