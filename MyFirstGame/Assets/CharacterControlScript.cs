using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlScript : MonoBehaviour
{
    Vector3 velocity, acceleration;

    float rateOfRotation = 180f;
    // Start is called before the first frame update
    void Start()
    {
       
    }
 
    // Update is called once per frame
    void Update()

    {  
        acceleration = Vector3.zero;

        if(Input.GetKey(KeyCode.W))
        { acceleration = transform.forward; };

        if (Input.GetKey(KeyCode.S))
        { acceleration = -transform.forward; };


        if (Input.GetKey(KeyCode.A))
        { transform.Rotate(Vector3.up, rateOfRotation * Time.deltaTime); };

        if (Input.GetKey(KeyCode.D))
        { transform.Rotate(Vector3.up, rateOfRotation * Time.deltaTime); };
        transform.position += velocity * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        { transform.Rotate(Vector3.forward, rateOfRotation * Time.deltaTime); };

        if (Input.GetKey(KeyCode.UpArrow))
        { transform.Rotate(Vector3.right, rateOfRotation * Time.deltaTime); }

        transform.position += velocity * Time.deltaTime;


        velocity += acceleration * Time.deltaTime;
    }
}
