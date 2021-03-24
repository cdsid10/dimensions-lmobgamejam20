using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disturbances : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Random.Range(-9, 9),Random.Range(-4.5f, 4.5f), 0));
    }

    void Dbances()
    {
        transform.Rotate(0,0,Random.Range(0f, 360f));
        
        
        
        
        Destroy(gameObject, 5f);
    }
}
