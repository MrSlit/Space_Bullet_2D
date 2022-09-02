using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    public bitis bitti;
    public GameObject patlama;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "oyuncu_gemisi")
        {
            Destroy(gameObject);
            GameObject yeni_patlama = Instantiate(patlama, transform.position, Quaternion.identity);
            Destroy(yeni_patlama, 1.0f);
            bitti.paneli_goster();

        }
    }
}
