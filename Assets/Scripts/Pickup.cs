using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private JumpsLeft _jumpsLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        _jumpsLeft = FindObjectOfType<JumpsLeft>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _jumpsLeft.jumpsLeft++;
        Destroy(gameObject);
    }
}
