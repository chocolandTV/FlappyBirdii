using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= getComponent<Rigidbody2D>();
    }
    public void OnJump(InputSystem.CallbackContext context)
    {
        Jump();
    }
    // Update is called once per frame
    void Jump()
    {
        
    }
}
