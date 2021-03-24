using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private DimensionChanger _dimensionChanger;
    
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        _dimensionChanger = FindObjectOfType<DimensionChanger>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        
        Vector2 movementX = new Vector2(moveX, 0);
        Vector2 movementY = new Vector2(0, moveY);
        
        if (_dimensionChanger.isVertical)
        {
            _rigidbody2D.velocity = movementY.normalized * (moveSpeed * Time.deltaTime);
        }
        else if (!_dimensionChanger.isVertical)
        {
            _rigidbody2D.velocity = movementX.normalized * (moveSpeed * Time.deltaTime);
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
        
    }
}
