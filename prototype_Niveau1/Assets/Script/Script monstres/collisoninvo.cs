using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisoninvo : MonoBehaviour
{
    public BarreVieM VieBarreM;


    /*void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Invocation")
        {
            if (VieBarreM )
            {
                VieBarreM.OnTakeDamage(3);
                
            }

        }
    }*/

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("InvocationVie"))
        {
            if (VieBarreM)
            {
                VieBarreM.OnTakeDamage(3);

            }

        }

    }
}
