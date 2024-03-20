using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static float maxVelocity;
    public float velocity_sideways = 60;
    public static Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        maxVelocity = 100;
        //print(this.transform.position);
        ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraControl.alive)
        {
            Debug.Log(ball.velocity.x + " " + maxVelocity);
            //    ball.velocity = new Vector3(10, ball.velocity.y, ball.velocity.z);
            //else
            if (ball.velocity.x < maxVelocity)
            {
                ball.velocity += new Vector3(20 * maxVelocity / 100 * Time.deltaTime, 0, 0);
            }
            else
            {
                //                ball.velocity += new Vector3(0.003f * maxVelocity-ball.velocity.x * Time.deltaTime, 0, 0);
                ball.velocity += new Vector3(maxVelocity - ball.velocity.x, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                ball.velocity += new Vector3(0, 0, velocity_sideways * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                ball.velocity += new Vector3(0, 0, -velocity_sideways * Time.deltaTime);
            }
            //this.transform.position += new Vector3(0, 0, Veloctiy_sideways * Time.deltaTime);
        }


    }
}
