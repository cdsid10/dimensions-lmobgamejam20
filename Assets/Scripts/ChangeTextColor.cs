using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTextColor : MonoBehaviour
{
    private DimensionChanger _dimensionChanger;

    [SerializeField] private TMP_Text jumpLeft;
    // Start is called before the first frame update
    void Start()
    {
        _dimensionChanger = FindObjectOfType<DimensionChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_dimensionChanger.isVertical)
        {
            jumpLeft.color =Color.white;
        }
        else
        {
            jumpLeft.color =Color.black;
        }
    }
}
