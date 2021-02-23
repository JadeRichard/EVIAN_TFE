using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public BarreVie VieBarre;
    
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "monstre")
        {
            if (VieBarre)
            {
                VieBarre.OnTakeDamage(1);
            }

        }
    }
}
