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

    float mermi = 100.0f;
    float simdiki_mermi = 100.0f;

    float kursun_hizi = 50.0f;

    void mermi_azalt(float deger)
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
        Run.AddForce(yeni_kursun.transform.forward * 2 * Time.deltaTime, ForceMode2D.Impulse);
        yeni_kursun.transform.eulerAngles = new Vector3(90 , yeni_kursun.transform.eulerAngles.y, yeni_kursun.transform.eulerAngles.z);
        //GameObject yeni_kursun = Instantiate(oyuncu_kursunu, transform.position, Quaternion.identity);
        //yeni_kursun.transform.rotation = namlu.transform.rotation;
        //yeni_kursun.GetComponent<Rigidbody2D>().AddForce(Vector2.up * kursun_hizi);
        //float poz_x = transform.position.x + (namlu.transform.localRotation.z) ;
        //float poz_y = transform.position.y - (namlu.transform.localRotation.z) ;

        //if (poz_y < 0)  poz_y = poz_y -2 ;


        //yeni_kursun.GetComponent<Rigidbody2D>().AddForce((new Vector2(poz_x, poz_y)) * -1 * kursun_hizi);
        //yeni_kursun.transform.localPosition=new Vector3()

        Destroy(yeni_kursun, 2.0f);
        mermi_azalt(20.0f);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ates_et();
        }
    }
}
