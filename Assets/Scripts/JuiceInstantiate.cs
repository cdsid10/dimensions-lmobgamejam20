using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceInstantiate : MonoBehaviour
{
    private JumpsLeft _jumpsLeft;
    
    [SerializeField] private GameObject juice;
    [SerializeField] private float timeRemaining;
    [SerializeField] private Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        _jumpsLeft = FindObjectOfType<JumpsLeft>();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnJuice();
    }
    
    void SpawnJuice()
    {
        if (_jumpsLeft.jumpsLeft >= 6)
        {
            return;
        }
        else if (_jumpsLeft.jumpsLeft < 6)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Vector3 spawn = new Vector3(Random.Range(-7, 7), Random.Range(-4.5f, 4.5f), 0f);
                if ((spawn - player.transform.position).magnitude < 2f)
                {
                    return;
                }
                else
                {
                    Instantiate(juice, spawn, Quaternion.identity);
                }
                
                timeRemaining = Random.Range(3f, 5f);
            }
                
        }
    }
}
