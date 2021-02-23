using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Monstre : MonoBehaviour
{
    public float Speed;
    public Vector3 userDirection = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        Speed = -5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(userDirection * Speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("combat"))
        {
            Speed = 0;

        }

        if (other.gameObject.CompareTag("monstre"))
        {
            Speed = 0;

        }

    }
}
