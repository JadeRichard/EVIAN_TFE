using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvocationSoin : MonoBehaviour
{
    //public GameObject SoinPrefab;

    //GameObject SoinObject;

    public GameObject SoinTarget;
    public Belatores SoinBelatores;

    public float SoinTimer;
    float SoinClock;

    // Start is called before the first frame update
    void Start()
    {
        SoinTarget = GameObject.Find("Perso");
        SoinBelatores = SoinTarget.GetComponent<Belatores>();

        //SoinObject = Instantiate(SoinPrefab, this.transform.position, Quaternion.identity) as GameObject;
        //SoinObject.transform.parent = this.transform;

    }

    // Update is called once per frame
    void Update()
    {
        SoinClock += Time.deltaTime;
        if (SoinClock >= SoinTimer)
        {
            SoinClock = 0.0f;
            SoinBelatores.ModifierVie(1);
        }
        
    }
}
