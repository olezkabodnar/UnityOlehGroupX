
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMoving : MonoBehaviour
{
    public float moveSpeed = 5f;
public float mouseSensitivity = 2f;

private float rotationX;
private float rotationY;

void Start()
{
    Cursor.lockState = CursorLockMode.Locked;
}

void Update()
{
    // move our camera forward, backward, left and right
    float moveX = Input.GetAxis("Horizontal");
    float moveZ = Input.GetAxis("Vertical");
    transform.position += new Vector3(moveX, 0f, moveZ) * moveSpeed * Time.deltaTime;

    // rotate our camera
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

    rotationX -= mouseY;
    rotationX = Mathf.Clamp(rotationX, -90f, 90f);

    rotationY += mouseX;

    transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
}
}