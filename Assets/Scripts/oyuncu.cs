using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyuncu : MonoBehaviour
{

    public GameObject oyuncu_kursunu;
    public Image mermi_sayisi;
    public bitis bitti;
    public GameObject patlama;
    public GameObject namlu;
    private int dusman_sayisi;
    public GameObject winpanel;

    float mermi = 100.0f;
    float simdiki_mermi = 100.0f;

    public void mermi_azalt(float deger)
    {
        simdiki_mermi -= deger;
        mermi_sayisi.fillAmount = simdiki_mermi / mermi;

        if (simdiki_mermi <= 0)
        {
     
            yok_ol();
        }
    }

     void yok_ol()
    {
        Destroy(gameObject);
        GameObject yeni_patlama = Instantiate(patlama, transform.position, Quaternion.identity);
        Destroy(yeni_patlama, 1.0f);
        bitti.paneli_goster();
    }




    void ates_et()
    {
        Vector3 SpawnPoint = namlu.transform.position;
        Quaternion SpawnRoot = namlu.transform.rotation;
        GameObject yeni_kursun = Instantiate(oyuncu_kursunu, SpawnPoint, SpawnRoot);
        Rigidbody2D Run = yeni_kursun.GetComponent<Rigidbody2D>();
        Run.AddForce(yeni_kursun.transform.up * 10, ForceMode2D.Impulse);

        Destroy(yeni_kursun, 2.0f);
        mermi_azalt(20.0f);

    }

   /* private void dusman_sayaci()
    {
        if (dusman_sayisi == 0)
        {
            winpanel.SetActive(true);
        }
    }

    public void DestroyedOneEnemyShip()
    {
        dusman_sayisi = dusman_sayisi - 1;
        dusman_sayaci();
    }

    public int GetEnemyShipCount()
    {
        return dusman_sayisi;
    }

    */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ates_et();
        }
    }
}
