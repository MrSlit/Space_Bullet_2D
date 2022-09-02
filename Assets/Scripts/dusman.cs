using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dusman : MonoBehaviour
{
    public Transform oyuncu;

    public GameObject patlama;
    public GameObject dusman_kursunu;
    public bitis bitti;
    public siradakiseviye Siradakiseviye;
    public int Score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oyuncu_kursunu")
        {
            yok_et();
        }
    }

    void yok_et(){
        Destroy(gameObject);
        GameObject yeni_patlama = Instantiate(patlama, transform.position, Quaternion.identity);
        Destroy(yeni_patlama, 1.0f);
        Score++;

        if(Score >= 1)
        {
            Siradakiseviye.kazanmayi_goster();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
