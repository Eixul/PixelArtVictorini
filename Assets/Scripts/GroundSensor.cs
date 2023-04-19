using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    
    public bool isGrounded;
    private ControlPlayer controller;

    
    // Start is called before the first frame update
    void Awake ()
    {
        controller = GetComponentInParent<ControlPlayer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
            controller.anim.SetBool("isJumping", false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
