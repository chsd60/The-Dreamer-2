using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;

    public float runSpeed = 40f;

    public float horizontalMove = 0f;

    bool jump = false;

    public GameObject sprite;
    public GameObject VFX;

    void Update() {

       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }
    }

    void FixedUpdate() {

        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }

    public void Death() {
        sprite.SetActive(false);
        VFX.SetActive(true);
        controller.dead = true;
    }
}
