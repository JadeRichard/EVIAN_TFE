using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Belatores : MonoBehaviour
{
    public enum ID { MONSTRE, INVOCATION, SOIN, INVOCATEUR };
    public ID type;
    public float Speed = 1;
    public int Strength = 1;
    public bool isFighting = false;
    public bool isWalking = true;
    public bool givelife = false;

    public GameObject other;
    public GameObject Invocatrice;
    public GameObject CharacterObject;
    public GameObject BarreObject;
    public bool Perso = true;
    public Image VieBarre;

    internal void OnTakeDamage()
    {
        throw new NotImplementedException();
    }

    public float vie;
    public float debutvie;

    Vector3 userDirection = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Soin>();
    }

    public void ModifierVie(int modification)
    {
        vie = vie + modification;
        VieBarre.fillAmount = vie / debutvie;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFighting && isWalking)
        {
            transform.Translate(userDirection * Speed * Time.deltaTime);
        }
    }

    void OnTriggerStay(Collider other)
    {
        Belatores belatores = other.gameObject.GetComponent<Belatores>();

        if (belatores && belatores.type != this.type)
        {
            if (other.gameObject.tag != "soin")
            {
                isFighting = true;


                bool isDead = belatores.OnTakeDamage(Strength);
                if (isDead)
                {
                    isFighting = false;
                }

                print("fight " + other.gameObject.name);
            } 

            /*else if (other.gameObject.tag == "soin")
            {
                print("soin!!!!!!!!!!!");

            }*/
        }
        else if (belatores && belatores.type == this.type)
        {
            isWalking = false;
        }
        else if (!belatores && ID.MONSTRE == this.type && other.gameObject.tag == "combat") {

            isWalking = false;
        }

        Soin soin = other.gameObject.GetComponent<Soin>();

        if (soin)
        {

            Debug.Log("casting soin");
            /*if (ID.MONSTRE != this.type)
            {
                soin.ApplySoin(this.gameObject);
            }*/
        }
    }


    void OnTriggerExit(Collider other)
    {
        Belatores belatores = other.gameObject.GetComponent<Belatores>();
        if (belatores && belatores.type == this.type)
        {
            isWalking = true;
        }
    }

  

    public bool OnTakeDamage(int damage)
    {

        /*if (soin == true)
        {
            vie = vie + damage;
        }*/

        ModifierVie(-damage);

        if (vie <= 0)
        {
            /*invocation_soin soin = this.gameObject.GetComponent<invocation_soin>();

            if (soin)
            {
                Destroy(soin.soinObject);
            }*/

            Destroy(CharacterObject.gameObject);
            Destroy(BarreObject.gameObject);
            if (Invocatrice == null)
            {
                Perso = false;
            }
            
            if (Perso == false)
            {
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            }
            return true;
        }
        return false;
    }
}
    
    
