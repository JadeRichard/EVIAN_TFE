using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveProjectile : MonoBehaviour
{
    public GameObject CharacterObject;
    public float Speed = -5;
    Vector3 userDirection = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(userDirection * Speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("destruction"))
        {

        
            Destroy(CharacterObject.gameObject);
        }
    }
    }
