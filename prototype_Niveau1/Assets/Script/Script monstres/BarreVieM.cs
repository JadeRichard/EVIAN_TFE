using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class BarreVieM : MonoBehaviour
{
    public GameObject CharacterObject;
    public GameObject BarreObject;
    public Image VieBarreM;
    public float vieM;
    public float debutvieM;

    public GameObject useGameObject;


    public void OnTakeDamage(int damage)
    {
        vieM = vieM - damage;
        VieBarreM.fillAmount = vieM / debutvieM;
        if (vieM <= 0)
        {           
            Destroy(CharacterObject.gameObject);        
            Destroy(BarreObject.gameObject);
        }

    }
    
}
