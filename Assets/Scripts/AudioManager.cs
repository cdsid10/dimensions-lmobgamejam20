using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private AudioClip warp, hit, pickup;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayWarp()
    {
        _audioSource.PlayOneShot(warp);
        _audioSource.pitch = Random.Range(0.7f, 1.3f);
    }
    
    public void PlayHit()
    {
        _audioSource.PlayOneShot(hit);
        _audioSource.pitch = Random.Range(0.7f, 1.3f);
    }
    
    public void PlayPickup()
    {
        _audioSource.PlayOneShot(pickup);
        _audioSource.pitch = Random.Range(0.7f, 1.3f);
    }
}
