using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectile;
    public GameObject ZoneInvocation;
    private float Timer = 6f;
    private float clock = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        //InvokeRepeating("LaunchProjectile", Timer, Timer);
        clock += Time.deltaTime;
        if (clock >= Timer)
        {
            clock = 0;
            LaunchProjectile();

        }
    }

    public void LaunchProjectile()
    {
        Instantiate(projectile, ZoneInvocation.transform.position + (transform.forward), transform.rotation);
    }

}
