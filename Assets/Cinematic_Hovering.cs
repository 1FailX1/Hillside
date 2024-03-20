using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematic_Hovering : MonoBehaviour
{
    private Rigidbody ball;

    private void Start()
    {
        ball = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        ball.velocity = new Vector3(75, -30, 0);
    }
}
