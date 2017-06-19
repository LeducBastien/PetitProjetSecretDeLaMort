using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private float jumpSpeed = 8.0f;
    private Vector3 MoveDir = Vector3.zero;

    // Use this for initialization
    protected override void Start ()
    {
        Life = 10;
        Speed = 10.0f;
        Gravity = 9.8f;	
	}

    // Update is called once per frame
    protected override void Update ()
    {
        CharacterController controller = GetComponent<CharacterController>();

        if (controller)
        {
            if (controller.isGrounded)
            {
                MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                MoveDir = transform.TransformDirection(MoveDir);
                MoveDir *= Speed;
            }

            MoveDir.y -= Gravity * Time.deltaTime;
            controller.Move(MoveDir * Time.deltaTime);
        }
	}
}
