using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionI : MonoBehaviour
{
    public BarreVieI VieBarreI;



    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "monstrevie")
        {
            if (VieBarreI)
            {
                VieBarreI.OnTakeDamage(2);
            }

        }
    }

    /*void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("monstrevie"))
        {
            if (VieBarreI)
            {
                VieBarreI.OnTakeDamage(2);

            }

        }

    }*/
}
