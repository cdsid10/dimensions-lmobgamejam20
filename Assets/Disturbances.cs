using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disturbances : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(new Vector2(Random.Range(-10f, 10f), Random.Range(-5f, 5f)) * Random.Range(10f, 30f));
    }

    // Update is called once per frame
    void Update()
    {
       Destroy(gameObject, Random.Range(6f, 11f));
    }
}
