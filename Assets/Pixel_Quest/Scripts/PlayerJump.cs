using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _Rigidbody2D;
    public float jumpForce = 10;
    public float CapsulelHeight = 0.25f;
    public float CapsuleRadius = 0.08f;
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            _Rigidbody2D.velocity = new Vector2(_Rigidbody2D.velocity.x, jumpForce);
            //animator.SetBool("isjumping", true);
            //animator.SetBool("iswalking", false);
        }  
      /*
      else
        {
            animator.SetBool("isjumping", false);
        }
      */

      if (_Rigidbody2D.velocity.y < 0)
        {
            animator.SetBool("isjumping", true);
            animator.SetBool("iswalking", false);
        }
        else
        {
            animator.SetBool("isjumping", false);
        }
    }
}
