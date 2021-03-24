using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionChanger : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    
    public bool isVertical = false;
    [SerializeField] private Sprite[] bgDimesnions;
    
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = Random.Range(0.8f, 1.2f);
            isVertical = !isVertical;
            if (isVertical)
            {
                _spriteRenderer.sprite = bgDimesnions[0];
            }
            else if (!isVertical)
            {
                _spriteRenderer.sprite = bgDimesnions[1];
            }
        }

        transform.Rotate(0f, 0f, 10f * Time.deltaTime);
    }
}
