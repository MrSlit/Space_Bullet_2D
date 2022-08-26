using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sahne_gecisi : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        
     
    }
    public void SiradakiBolumuYukle()
    {
        StartCoroutine(BolumYukle(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator BolumYukle (int levelIndex)
    {
        transition.SetTrigger("New_Screen");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);
    }
}
