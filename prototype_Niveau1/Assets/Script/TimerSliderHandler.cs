using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;


public class TimerSliderHandler : MonoBehaviour
{
    [SerializeField] public TimerSider timerslider;

    public GameObject Zonetimer;

    bool canCoolDown = true;

    public float coolDown = 5.0f;

    // Start is called before the first frame update
    public void Start()
    { //timerslider.SetSize(.004f);
       



    }

    public void Update()
    {
            if (Input.GetKeyDown("w"))
            {
            InvokeandWait(1);
            
            }
            
    }

    public void InvokeandWait(int InvocationNumber)
    {
        if (canCoolDown == false)
        {
            return;
        }

        if (InvocationNumber == 1)
        {
            CreateInvocation1();
        }

        canCoolDown = false;
        Invoke("CooledDown", coolDown);
    }

    public void CreateInvocation1()
    {
        Instantiate(timerslider, Zonetimer.transform.position + (transform.forward), transform.rotation);
    }

    void CooledDown()
    {

        canCoolDown = true;

    }
}

