using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject Character;
    public float Speed = 5f;
    public bool canControl;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(Speed));
        if (canControl == true)
        {
            float h = Input.GetAxis("Horizontal") * Speed;

            Character.transform.Translate(h * Time.deltaTime, 0, 0);
        }
    }
}
