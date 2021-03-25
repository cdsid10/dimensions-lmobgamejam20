using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.SceneManagement;
using UnityEngine;
using Random = UnityEngine.Random;

public class DimensionPool : MonoBehaviour
{
    [SerializeField] private GameObject[] dBances;
    [SerializeField] private GameObject dAttack;
    [SerializeField] private float timeRemaining, aTimeRemaining;
    [SerializeField] private Transform player;
    
    // Update is called once per frame
    void Update()
    {
        Spawner();
        AttackSpawner();
    }

    void Spawner()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (timeRemaining <= 0)
        {
            Vector3 spawn = new Vector3(Random.Range(-8, 8), Random.Range(-5f, 5f), 0f);
            if ((spawn - player.transform.position).magnitude < 4)
            {
                return;
            }
            else
            {
                Instantiate(dBances[Random.Range(0, dBances.Length)], spawn, Quaternion.identity);
            }
            timeRemaining = Random.Range(0.15f, 1.25f);
        }
    }
    
    private void AttackSpawner()
    {
        if (aTimeRemaining > 0)
        {
            aTimeRemaining -= Time.deltaTime;
        }
        else if (aTimeRemaining <= 0)
        {
            Vector3 spawn = new Vector3(Random.Range(-8, 8), Random.Range(-5f, 5f), 0f);
            if ((spawn - player.transform.position).magnitude < 4)
            {
                return;
            }
            else
            {
                Instantiate(dAttack, spawn, Quaternion.identity);
            }

            aTimeRemaining = Random.Range(1.5f, 4f);
        }
    }
}
