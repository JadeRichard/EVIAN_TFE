using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] GameObject[] Waves;

    public int WaveID;
    public bool InWave;
    
    // Start is called before the first frame update
    void Start()
    {
        WaveID = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( InWave == true)
        {
            if (Waves[WaveID].GetComponent<WaveObject>().InSpawn == false)
            {
                Waves[WaveID].GetComponent<WaveObject>().StopWave();

                WaveID += 1;
                if (WaveID >= Waves.Length)
                {
                    InWave = false;
                }

                if ( InWave == true)
                {
                    Waves[WaveID].GetComponent<WaveObject>().StartWave();
                }
                
            }
        }
        
    }
}
