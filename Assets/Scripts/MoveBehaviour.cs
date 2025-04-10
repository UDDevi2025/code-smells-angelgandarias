using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{

    private Rigidbody playerRigidbody;

    public float movementSpeed;
    public float rotateSpeed;

    private void Update()
    {
        playerRigidbody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W))
        {
            // Move forward
            playerRigidbody.MovePosition(transform.position + transform.forward * movementSpeed * Time.deltaTime * 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Move backward
            playerRigidbody.MovePosition(transform.position + transform.forward * movementSpeed * Time.deltaTime * -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Rotate left
            RotatePlayer(-1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Rotate right
            RotatePlayer(1);
        }
    }

    private void RotatePlayer(int direction)
    {
        playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.up * rotateSpeed * Time.deltaTime * direction));
    }
}