using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpsLeft : MonoBehaviour
{
    public int jumpsLeft;

    [SerializeField] private int jumpsToCompleteLoop;
    // Start is called before the first frame update
    void Start()
    {
        jumpsToCompleteLoop = Random.Range(30, 50);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpsToCompleteLoop--;
            jumpsLeft--;
            if (jumpsLeft <= 0)
            {
                Debug.Log(("Khatam, Tata, Bye Bye"));
            }

            if (jumpsToCompleteLoop <= 0)
            {
                Debug.Log("Jeet Gaya Madarchod");
            }
        }
    }
}
