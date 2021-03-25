using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColor : MonoBehaviour
{
    private DimensionChanger _dimensionChanger;
    private ParticleSystem _particleSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        _dimensionChanger = FindObjectOfType<DimensionChanger>();
        _particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_dimensionChanger.isVertical)
        {
            var main = _particleSystem.main;
            main.startColor = Color.white;
        }
        else
        {
            var main = _particleSystem.main;
            main.startColor = Color.black;
        }
    }
}
