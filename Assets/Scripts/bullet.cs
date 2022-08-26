using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public siradakiseviye siradaki;

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dusman_gemisi")
        {
            yok_ol(collision.gameObject);
            siradaki.kazanmayi_goster();
        }
    }

    void yok_ol(GameObject enemyShip){
        enemyShip.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
