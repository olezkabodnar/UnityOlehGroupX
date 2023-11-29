using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdScript : MonoBehaviour

{
    Animator edAnimations;
    // Start is called before the first frame update
    void Start()
    {
        edAnimations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {   if(Input.GetMouseButtonDown(0)):
        {
           edAnimations.SetBool("shouldWave", true);
        }
    }
}
