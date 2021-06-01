using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Soin : MonoBehaviour
{

    public GameObject other;
    public bool soin = false;
    // Start is called before the first frame update
    void Start()
    {

    }

   /* public void ApplySoin(GameObject apply_object)
    {
        Debug.Log("applying soin to " + apply_object.name);

        
        belatores.vie += 10 * Time.deltaTime;
    }*/

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerStay(Collider other)
    {
        /*GetComponent<Belatores>();
        
        other.GetComponent<Belatores>().OnTakeDamage();*/

        
        /*Belatores belatores = apply_object.GetComponent<Belatores>();*/
        if (other.gameObject.tag == "oskour")
        {
            
            print("soin!!!!!!!!!!!");
            soin = true;
        }
    }
}

    
