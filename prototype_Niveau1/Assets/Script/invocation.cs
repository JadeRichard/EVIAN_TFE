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

    public float coolDown1 = 3;
    public float coolDown2 = 5;
    public float coolDown3 = 10;
    public float coolDownTimer1;
    public float coolDownTimer2;
    public float coolDownTimer3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){ 
  //...
  if (Input.GetKeyDown(KeyCode.W)){
    CreateInvocation1();
  }
  if (Input.GetKeyDown(KeyCode.X)){
            CreateInvocation2();
  }
  if (Input.GetKeyDown(KeyCode.C)){
    CreateInvocation3();
  }
}

public void CreateInvocation1(){
  if(coolDownTimer1 == 0){
    Instantiate(Invocation1, ZoneInvocation.transform.position + (transform.forward), transform.rotation);
    coolDownTimer1 = coolDown1;
  }
}

public void CreateInvocation2(){
  if(coolDownTimer2 == 0){
    Instantiate(Invocation2, ZoneInvocation.transform.position + (transform.forward), transform.rotation);
    coolDownTimer2 = coolDown2;
  }
}

public void CreateInvocation3(){
  if(coolDownTimer3 == 0){
    Instantiate(Invocation3, ZoneInvocation.transform.position + (transform.forward), transform.rotation);
      coolDownTimer3 = coolDown3;
  }
}
}
