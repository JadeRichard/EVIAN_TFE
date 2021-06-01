using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invocation_Move : MonoBehaviour
{

    public float Speed;

    public bool Combat;

    public Vector3 userDirection = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        Combat = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(userDirection * Speed * Time.deltaTime);
        if (Combat == true)
        {
            Speed = 0;
        }
        else
        {
            Speed = 8;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monstre"))
        {
            Combat = true;
        }

        /*if (other.gameObject.CompareTag("Invocation"))
        {
            Combat = true;
        }*/
        else
        {
            Combat = false;
        }
        

    }

    void OnTriggerExit(Collider other)
    {
        Speed = 8;
        Combat = false;
    }
}
