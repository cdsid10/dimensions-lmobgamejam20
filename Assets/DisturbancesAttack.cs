using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisturbancesAttack : MonoBehaviour
{
    private JumpsLeft _jumpsLeft;
    
    private Rigidbody2D _rigidbody2D;
    private Animator _camAnimator;
    
    [SerializeField] private Transform player;
    [SerializeField] private GameObject particles;
    
    // Start is called before the first frame update
    void Start()
    {
        _jumpsLeft = FindObjectOfType<JumpsLeft>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _camAnimator = Camera.main.GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
        _rigidbody2D.AddForce((player.position - transform.position).normalized * (150f), ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,-40f * Time.deltaTime);
        Destroy(gameObject, Random.Range(5f, 10f));
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject, 0.05f);
            Instantiate(particles, transform.position, Quaternion.identity);
        }

        if (other.CompareTag("Player"))
        {
            _camAnimator.SetTrigger("hit");
            _jumpsLeft.jumpsLeft--;
            _jumpsLeft.jumpsLeft--;
        }
    }
}
