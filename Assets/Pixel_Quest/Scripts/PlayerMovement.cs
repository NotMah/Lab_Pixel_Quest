using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public int speed = 4;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = transform.GetComponentInChildren<SpriteRenderer>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        _rigidbody2D.velocity = new Vector2(horizontal * speed, _rigidbody2D.velocity.y);

        if (horizontal > 0) { _spriteRenderer.flipX = false; }
        else if (horizontal < 0) { _spriteRenderer.flipX = true;}
        if (horizontal != 0)
        {
            _animator.SetBool("iswalking", true);

        }
        else
        {
            _animator.SetBool("iswalking", false);
        }
        //if (Input.GetKeyDown(KeyCode.Space) && _groundC

    }
}
