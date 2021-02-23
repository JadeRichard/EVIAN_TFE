using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public Camera GameCamera;
    public GameObject CharacterPrefab;
    public GameObject CharacterObject;
    public GameObject LaBarre;
    public GameObject BarrePrefab;
    public GameObject BarreObject;


    // Start is called before the first frame update
    void Start()
    {
    }

    public void CreateCharacter()
    {
        CharacterObject = Instantiate(CharacterPrefab, this.transform.position, Quaternion.identity) as GameObject;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (CharacterObject == null)
        {
            CreateCharacter();

        }
        if (LaBarre == null)
        {
            BarreObject = Instantiate(BarrePrefab, this.transform.position, Quaternion.identity) as GameObject;
        }

    }
}