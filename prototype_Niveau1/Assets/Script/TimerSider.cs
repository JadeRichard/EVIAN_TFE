using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSider : MonoBehaviour
{
    private Transform timerslider;

    // Start is called before the first frame update
    private void Start()
    {
        timerslider = transform.Find("Timer");
        
        
    }

    // Update is called once per frame
    public void SetSize(float sizeNormalized)
    {
        timerslider.localScale = new Vector3(sizeNormalized, 1f);
    }
}
