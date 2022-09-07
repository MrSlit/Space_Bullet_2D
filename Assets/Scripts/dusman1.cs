using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dusman1 : MonoBehaviour
{
    public Transform oyuncu;

    public GameObject patlama;
    public GameObject dusman_kursunu;
    public bitis bitti;
    public siradakiseviye Siradakiseviye;
    public int Score;
    public GameObject winpanel;
    public AudioSource patlama_sesi;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oyuncu_kursunu")
        {
            yok_et();
            patlama_sesi.Play();
        }
    }

    void yok_et(){
        Destroy(gameObject);
        GameObject yeni_patlama = Instantiate(patlama, transform.position, Quaternion.identity);
        Destroy(yeni_patlama, 1.0f);
        Score++;

        if(Score >= 2)
        {
            winpanel.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
