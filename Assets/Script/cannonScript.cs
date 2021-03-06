using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonScript : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    float timeBetween;
    public float startTimeBetween;

    void Start()
    {
        timeBetween = startTimeBetween;
    }

    void Update()
    {
        if(timeBetween <= 0)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            timeBetween = startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }
}
