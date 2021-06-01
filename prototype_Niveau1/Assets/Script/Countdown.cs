using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public float time = 0f;
    public float starttime = 5f;

    [SerializeField] Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            time = starttime;
        }
        time -= 1 * Time.deltaTime;
        TimerText.text = time.ToString ("0");

        if (time <= 0)
        {
            time = 0;
        }
    }
}
