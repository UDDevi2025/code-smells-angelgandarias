using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{

    private Rigidbody playerRigidbody;

    public float movementSpeed;
    public float rotateSpeed;
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            // Move forward
            Move(1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Move backward
            Move(-1);
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

    private void Move(int direction)
    {
        playerRigidbody.MovePosition(transform.position + transform.forward * movementSpeed * Time.deltaTime * direction);
    }

    private void RotatePlayer(int direction)
    {
        playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.up * rotateSpeed * Time.deltaTime * direction));
    }
}