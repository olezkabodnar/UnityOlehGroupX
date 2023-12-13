using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterControlScript : MonoBehaviour
{
    public float speed = 0.3f;
    public float mouseSensitivity = 3000000f;



    void Start()
    {

    }




    
    void Update()
    {
        float rotationX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;//move mouse
        float rotationY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationX);
        transform.Rotate(Vector3.left, rotationY);


        float moveHorizontal = Input.GetAxis("Horizontal");//move character
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.position += movement * speed * Time.deltaTime;
    }
}
