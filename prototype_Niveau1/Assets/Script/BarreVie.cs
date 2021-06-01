using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarreVie : MonoBehaviour
{
    public GameObject CharacterObject;
    public GameObject BarreObject;
    public Image VieBarre;
    public float vie;
    public float debutvie;
    

    public void OnTakeDamage (int damage)
    {
        vie = vie - damage;
        VieBarre.fillAmount = vie / debutvie;
        if (vie <= 0)
        {
            Destroy(CharacterObject.gameObject);
            Destroy(BarreObject.gameObject);
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("fin"))
        {
            /*Destroy(CharacterObject.gameObject);
            Destroy(BarreObject.gameObject);*/
            SceneManager.LoadScene("Scene2", LoadSceneMode.Single);

        }

    }

}