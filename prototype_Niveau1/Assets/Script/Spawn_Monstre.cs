using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Monstre : MonoBehaviour
{

    public GameObject Monstre1;
    public GameObject ZoneInvocation;
    public float Timer = 5; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Instantiate(Monstre1, ZoneInvocation.transform.position + (transform.forward), transform.rotation);
            Timer = 5;
        }
        
    }
}
