using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Invocateur : MonoBehaviour
{
    public float Speed;
    public Vector3 userDirection = Vector3.right;
    public List<GameObject> monsters;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        List<GameObject> temp = new List<GameObject>();
        foreach (GameObject g in monsters)
        {
            if (g != null) temp.Add(g);
        }
        monsters = temp;
        if (monsters.Count == 0)
        {
            transform.Translate(userDirection * Speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monstre"))
        {
            monsters.Add(other.gameObject);
        }
    }
}
