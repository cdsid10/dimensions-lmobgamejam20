using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.SceneManagement;
using UnityEngine;
using Random = UnityEngine.Random;

public class DimensionPool : MonoBehaviour
{
    [SerializeField] private GameObject dBances;
    private float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(dBances, transform.position, quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining <= 0)
        {
            Instantiate(dBances, transform.position, quaternion.identity);
            timeRemaining = Random.Range(1f, 3f);
        }
    }
}
