using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{

    public float speed = 3;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}