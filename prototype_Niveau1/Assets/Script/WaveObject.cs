using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveObject : MonoBehaviour
{
    public GameObject CharacterP, CameraP, SpawnP;
    Vector3 ChPosition, CaPosition, SpPosition;

    [SerializeField] GameObject[] WavePrefabs;
    [SerializeField] float[] WaveTimers;
    int PrefabID;
    float WaveClock;

    public bool InSpawn;



    // Start is called before the first frame update
    void Start()
    {
        ChPosition = CharacterP.transform.position;
        CaPosition = CameraP.transform.position;
        SpPosition = SpawnP.transform.position;

        PrefabID = 0;
    }
  

    public void StartWave()
    {
        InSpawn = true;
    }

    public void StopWave()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (InSpawn == true)
        {
            WaveClock += Time.deltaTime;

            if (WaveClock >= WaveTimers[PrefabID])
            {
                WaveClock = 0.0f;

                GameObject invocation_object = Instantiate(WavePrefabs[PrefabID], SpPosition, Quaternion.identity) as GameObject;

                PrefabID += 1;

                if (PrefabID >= WavePrefabs.Length)
                {
                    InSpawn = false;
                }
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("perso"))
        {
            InSpawn = true;

        }

    }

}
