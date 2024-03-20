using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FellOutOfWorld_Collision : MonoBehaviour
{
    private GameManager gm;
    public static bool foowcollsion = false;

    private void Start()
    {
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Fell out of world Collision
        CameraControl.endVelocity_x = PlayerControl.ball.velocity.x;
        CameraControl.endVelocity_y = PlayerControl.ball.velocity.y;
        CameraControl.OriginalEndVelocity_x = CameraControl.endVelocity_x;
        CameraControl.OriginalEndVelocity_y = CameraControl.endVelocity_y;
        CameraControl.alive = false;
        foowcollsion = true;
        PlayerControl.ball.velocity = new Vector3(0, 0, 0);
        Destroy(PlayerControl.ball);
        gm.ON_DEATH_Canvas_activate();

    }

}
