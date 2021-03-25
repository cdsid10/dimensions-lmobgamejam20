using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeJuiceColor : MonoBehaviour
{
    private DimensionChanger _dimensionChanger;

    private SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _dimensionChanger = FindObjectOfType<DimensionChanger>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_dimensionChanger.isVertical)
        {
            _spriteRenderer.color = Color.white;
        }
        else
        {
            _spriteRenderer.color = new Color(0,0,0,0.75f);
        }
    }
}
