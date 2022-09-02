using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dusman02 : MonoBehaviour
{
    public Transform oyuncu;

    public GameObject patlama;
    public GameObject dusman_kursunu;
    public bitis bitti;
    public siradakiseviye Siradakiseviye;
    public int Score;
    BoxCollider2D _col;
    public GameObject kalkan;

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

    void Start()
    {
        _col = gameObject.GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _col.enabled = !_col.enabled;

           if (kalkan.activeInHierarchy == true)
            {
                kalkan.SetActive(false);
            }
           else
            {
                kalkan.SetActive(true);
            }
        }

    }
}