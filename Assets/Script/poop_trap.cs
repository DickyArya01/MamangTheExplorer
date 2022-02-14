using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poop_trap : MonoBehaviour
{
    public Sprite sp1, sp2;
    public float trapRange;
    public LayerMask whatIsPlayer;
    private bool isInTrapRange;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sp1;
    }    
    private void Update()
    {
        isInTrapRange = Physics2D.OverlapCircle(transform.position, trapRange, whatIsPlayer);
        if(isInTrapRange)
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }      
    }
}
