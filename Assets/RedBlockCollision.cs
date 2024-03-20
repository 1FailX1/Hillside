using UnityEngine;

public class RedBlockCollision : MonoBehaviour
{
    private GameManager gm;
    public static bool rbcollsion = false;

    private void Start()
    {
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Variant 1
        CameraControl.alive = false;
        rbcollsion = true;
        CameraControl.endVelocity_x = PlayerControl.ball.velocity.x;
        CameraControl.OriginalEndVelocity_x = CameraControl.endVelocity_x;
        PlayerControl.ball.velocity = new Vector3(0, 0, 0);
        Destroy(PlayerControl.ball, 3);
        gm.ON_DEATH_Canvas_activate();
        
    }

}
