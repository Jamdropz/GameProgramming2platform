using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 5; 
	public float jumpForce = 7;
	public SphereCollider col;

	private bool isGrounded;
	public LayerMask whatisGround;
	public Transform groundCheck;
	public float checkRadius;

	private float moveInput;
	private Rigidbody rb;

	void Start () {
		
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate (){
		//isGrounded= Physics.OverlapSphere(groundCheck.position, checkRadius, whatisGround

		moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
		rb.velocity = new Vector3 (moveInput * speed, rb.velocity.y, rb.velocity.z);
	}


    void Update (){
        //if(isGrounded == true ) {
        //    extraJumps = extraJumpsValue;
        //}
        //if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0){
        //    rb.velocity = Vector3.up * jumpForce;
        //    extraJumps--;
        //} else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true){
        //    rb.velocity = Vector3.up * jumpForce;
        //}

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector3.up * jumpForce;
        }
    }
	void OnTriggerEnter(Collider other)
	{
		if(other.name == "Player1")
		{ Destroy(gameObject); 
		}

}