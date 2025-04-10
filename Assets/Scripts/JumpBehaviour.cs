using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{
    private int jumpForce = 400;
    public Rigidbody playerRigidbody;

    private bool isGrounded;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = false;
        }
    }

    void Update()
    {

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = new Vector3(0,1,0) * jumpForce;
            playerRigidbody.AddForce(jumpVector);
        }
    }

}