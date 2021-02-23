using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invocationmonstre : MonoBehaviour
{

    public GameObject Monstre1;
    public GameObject ZoneInvocation;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Monstre1, ZoneInvocation.transform.position + (transform.forward), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
