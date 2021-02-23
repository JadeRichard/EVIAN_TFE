using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceivePosition : MonoBehaviour
{
    public OSC osc;
    // lie le script invocation au script ReceivePosition
    public invocation invoc;

    void Start()
    {
        osc.SetAddressHandler("/position/d", OnReceiveD);
        osc.SetAddressHandler("/position/g", OnReceiveG);
        osc.SetAddressHandler("/position/h", OnReceiveH);
        osc.SetAddressHandler("/position/b", OnReceiveB);
    }

    void OnReceiveD(OscMessage message)
    {
        invoc.CreateInvocation1();
    }

    void OnReceiveG(OscMessage message)
    {
        invoc.CreateInvocation2();
    }

    void OnReceiveH(OscMessage message)
    {
        invoc.CreateInvocation3();
    }

    void OnReceiveB(OscMessage message)
    {
        ///....
    }

    private void Update()
    {
    }
}