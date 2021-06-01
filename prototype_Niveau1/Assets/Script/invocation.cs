using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class invocation : MonoBehaviour
{

    public GameObject Invocation1;
    public GameObject Invocation2;
    public GameObject Invocation3;
    public GameObject PersoPrincipale;
    public GameObject ZoneInvocation;

    bool canInstantiate = true;

    public float coolDown = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){ 
  //...
  if (Input.GetKeyDown(KeyCode.W) )
        {
            InvokeandWait(1);
        }
  if (Input.GetKeyDown(KeyCode.X) )
        {
            InvokeandWait(2);
        }
  if (Input.GetKeyDown(KeyCode.C) )
        {
            InvokeandWait(3);
        }
}

public void InvokeandWait (int InvocationNumber)
    {
        if (canInstantiate == false)
        {
            return;
        }

        if (InvocationNumber == 1)
        {
            CreateInvocation1();
        }

        if (InvocationNumber == 2)
        {
            CreateInvocation2();

        }
        if (InvocationNumber == 3)
        {
            CreateInvocation3();

        }
        canInstantiate = false;
        Invoke("CooledDown", coolDown);
    }

public void CreateInvocation1(){
    Instantiate(Invocation1, ZoneInvocation.transform.position + (transform.forward), transform.rotation);
}

public void CreateInvocation2(){
    Instantiate(Invocation2, ZoneInvocation.transform.position + (transform.forward), transform.rotation);
}

public void CreateInvocation3(){
    Instantiate(Invocation3, ZoneInvocation.transform.position + transform.forward, transform.rotation);
}

    void CooledDown()
    {

        canInstantiate = true;

    } 


}
