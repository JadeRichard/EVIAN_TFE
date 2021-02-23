using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreVieI : MonoBehaviour
{
    public GameObject CharacterObject;
    public GameObject BarreObject;
    public Image VieBarreI;
    public float vieI;
    public float debutvieI;


    public void OnTakeDamage(int damage)
    {
        vieI = vieI - damage;
        VieBarreI.fillAmount = vieI / debutvieI ;
        if (vieI <= 0)
        {
            Destroy(CharacterObject.gameObject);
            Destroy(BarreObject.gameObject);
        }

    }
}
