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
        osc.SetAddressHandler("/position/1", OnReceive1);
        osc.SetAddressHandler("/position/2", OnReceive2);
        osc.SetAddressHandler("/position/3", OnReceive3);
        osc.SetAddressHandler("/position/4", OnReceive4);
        osc.SetAddressHandler("/position/5", OnReceive5);
        osc.SetAddressHandler("/position/6", OnReceive5);
    }

    void OnReceive1(OscMessage message)
    {
        invoc.InvokeandWait(1);
    }

    void OnReceive2(OscMessage message)
    {
        invoc.InvokeandWait(2);
    }

    void OnReceive3(OscMessage message)
    {
        invoc.InvokeandWait(3);
    }

    void OnReceive4(OscMessage message)
    {
        invoc.InvokeandWait(2);
    }
    void OnReceive5(OscMessage message)
    {
        ///....
    }
    void OnReceive6(OscMessage message)
    {
        ///....
    }

    private void Update()
    {
    }
}