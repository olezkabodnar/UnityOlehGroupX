using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterControlScript : MonoBehaviour
{
    public float speed = 0.1f;
    public float mouseSensitivity = 300f;
    public GameObject BulletLite_02; // Префаб кулі
    public Transform firePoint; // Точка вистрілу



    void Start()
    {

    }




    
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        float rotationX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;//move mouse
        float rotationY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationX);
        transform.Rotate(Vector3.left, rotationY);


        float moveHorizontal = Input.GetAxis("Horizontal");//move character
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.position += movement * speed * Time.deltaTime;
    }

    void Shoot()
    {
        // Створення екземпляра кулі на точці вистрілу
        GameObject bullet = Instantiate(BulletLite_02, firePoint.position, firePoint.rotation);

        // Додавання сили вистрілу кулі
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.AddForce(firePoint.forward * 1f, ForceMode.Impulse);
    }
}
