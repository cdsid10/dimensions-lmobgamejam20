using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class JumpsLeft : MonoBehaviour
{
    private Pause _pause;
    
    public int jumpsLeft;

    [SerializeField] private TMP_Text warpLeft, jumpLeft;
    [SerializeField] private int jumpsToCompleteLoop;
    // Start is called before the first frame update
    void Start()
    {
        _pause = FindObjectOfType<Pause>();
        jumpsToCompleteLoop = Random.Range(15, 30);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_pause.paused)
        {
            jumpsToCompleteLoop--;
            jumpsLeft--;
        }
        if (jumpsLeft <= 0)
        {
            SceneManager.LoadScene(3);
        }

        if (jumpsToCompleteLoop <= 0)
        {
            SceneManager.LoadScene(2);
        }

        jumpLeft.text = jumpsLeft.ToString();
        warpLeft.text = jumpsToCompleteLoop.ToString();
    }
}
