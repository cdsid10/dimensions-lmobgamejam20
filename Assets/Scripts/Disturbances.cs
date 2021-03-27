using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Disturbances : MonoBehaviour
{
    private AudioManager _audioManager;
    private JumpsLeft _jumpsLeft;
    
    private Rigidbody2D _rigidbody2D;
    private Animator _camAnimator;
    
    [SerializeField] private float[] rotatePack;
    [SerializeField] private GameObject particles;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioManager = FindObjectOfType<AudioManager>();
        _jumpsLeft = FindObjectOfType<JumpsLeft>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _camAnimator = Camera.main.GetComponent<Animator>();
        transform.Rotate(new Vector3(0,0, Random.Range(-90,90)));
        _rigidbody2D.AddForce(new Vector2(Random.Range(-10f, 10f), Random.Range(-5f, 5f)) * Random.Range(0.5f, 15f));
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, Random.Range(8f, 11f));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject, 0.05f);
            Instantiate(particles, transform.position, quaternion.identity);
        }
        
        if (other.CompareTag("Player"))
        {
            _camAnimator.SetTrigger("hit");
            _jumpsLeft.jumpsLeft--;
            _audioManager.PlayHit();
        }
    }
}


