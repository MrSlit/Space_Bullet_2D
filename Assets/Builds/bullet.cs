using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dusman_gemisi")
        {
            yok_ol(collision.gameObject);
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