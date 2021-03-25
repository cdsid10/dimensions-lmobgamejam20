using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDisturbanceColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    [SerializeField] private Color[] _colors;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        int lengthOfColors = _colors.Length;
        int rndColor = Random.Range(0, lengthOfColors);
        _spriteRenderer.color = _colors[rndColor];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
