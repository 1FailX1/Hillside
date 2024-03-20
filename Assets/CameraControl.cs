using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject PlayerBall;
    public static bool alive;
    public static float endVelocity_x;
    public static float OriginalEndVelocity_x;
    public static float endVelocity_y;
    public static float OriginalEndVelocity_y;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -120, 0);
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {

            this.transform.position = PlayerBall.transform.position + new Vector3(-3.5f, 5.4f, 0);
        }
        else if(RedBlockCollision.rbcollsion)
        {
            if (endVelocity_x > 0)
            {
                this.transform.position += new Vector3(endVelocity_x * Time.deltaTime, 0, 0);
                endVelocity_x -= (OriginalEndVelocity_x) * Time.deltaTime;
            }
        }else if (FellOutOfWorld_Collision.foowcollsion)
        {
            if (endVelocity_x > 0)
            {
                this.transform.position += new Vector3(endVelocity_x * Time.deltaTime, endVelocity_y * Time.deltaTime, 0);
                endVelocity_x -= (OriginalEndVelocity_x) * Time.deltaTime;
                endVelocity_y -= (OriginalEndVelocity_y) * Time.deltaTime;
            }
        }
    }
}