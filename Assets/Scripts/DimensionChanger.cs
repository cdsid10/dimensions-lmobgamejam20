using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionChanger : MonoBehaviour
{
    private AudioManager _audioManager;
    private Pause _pause;
    
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private Animator camAnimator;
    
    public bool isVertical = false;
    [SerializeField] private Sprite[] bgDimesnions;
    [SerializeField] private GameObject introText;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioManager = FindObjectOfType<AudioManager>();
        _pause = FindObjectOfType<Pause>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && !_pause.paused)
        {
            Destroy(introText, 2.5f);
            int randomNumber = Random.Range(1, 3);
            camAnimator.SetInteger("warp", randomNumber);
            isVertical = !isVertical;
            if (isVertical)
            {
                _spriteRenderer.sprite = bgDimesnions[0];
            }
            else if (!isVertical)
            {
                _spriteRenderer.sprite = bgDimesnions[1];
            }
            _audioManager.PlayWarp();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            camAnimator.SetInteger("warp", 0);
        }
        

    }
}
