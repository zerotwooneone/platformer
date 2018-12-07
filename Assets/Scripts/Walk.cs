using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    Animator animator;

    public float MoveSpeed = 3f;
	// Use this for initialization
	void Start ()
	{
	    animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Movement();
	    float move = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", move);
	}

    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, -180);
        }
    }
}
