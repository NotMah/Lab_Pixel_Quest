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
    public float fallForce = 2;
    private Vector2 _gravityVector;
    public float _rigidbody2D;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        _gravityVector = new Vector2(0, Physics2D.gravity.y);
        _Rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();    
    }

    // Update is called once per frame
    void Update()

    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsulelHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundMask);
      if (Input.GetKeyDown(KeyCode.Space) &&  _groundCheck)
        {
            animator.SetBool("isjumping", true);
            _Rigidbody2D.velocity = new Vector2(_Rigidbody2D.velocity.x, jumpForce);
      
        }


        if (_Rigidbody2D.velocity.y > 0)
        {
   
            _Rigidbody2D.velocity += _gravityVector * (fallForce * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isjumping", false);
        }
       






    }
}
