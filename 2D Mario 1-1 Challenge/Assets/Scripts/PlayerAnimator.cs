using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    private Animator anim;
    private PlayerController controller;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        controller = GetComponent<PlayerController>();
}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetAxis("Horizontal") != 0) {
            anim.SetBool("isMoving", true);
        }
        else {
            anim.SetBool("isMoving", false);
        }
	}

    public void animJump(bool active) {
        if (active == true) {
            anim.SetBool("isJumping", true);
        }
        else {
            anim.SetBool("isJumping", false);
        }
    }

    public void animCrouch(bool active)
    {
        if (active == true)
        {
            anim.SetBool("isCrouching", true);
        }
        else
        {
            anim.SetBool("isCrouching", false);
        }
    }

    public void animPower(bool active)
    {
        if (active == true)
        {
            anim.SetBool("isPoweredUp", true);
        }
        else
        {
            anim.SetBool("isPoweredUp", false);
        }
    }
}
