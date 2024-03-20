using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSpeedUp : MonoBehaviour
   
{
    private GameManager gm;
    private void Start()
    {
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerControl.maxVelocity += 10f;
        gm.OnSpeedUpCollision();
    }

  
}
