using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public siradakiseviye siradaki;
    public AudioSource patlama;

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dusman_gemisi")
        {
            yok_ol(collision.gameObject);
         
          
        }
    }

    void yok_ol(GameObject enemyShip){
        enemyShip.SetActive(false);
        patlama.Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
