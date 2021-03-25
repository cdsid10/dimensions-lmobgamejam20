using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Pickup : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    
    private JumpsLeft _jumpsLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _jumpsLeft = FindObjectOfType<JumpsLeft>();
        _rigidbody2D.AddForce(new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _jumpsLeft.jumpsLeft++;
            Destroy(gameObject);
        }
        
    }
}
