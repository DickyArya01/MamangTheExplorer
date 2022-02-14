using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScriptV : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up* speed ;
        // Destroy(gameObject,1f);
    }
// 
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Block")
        {
            Destroy(gameObject);
        }   
    }}
