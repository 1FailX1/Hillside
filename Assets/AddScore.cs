using UnityEngine;

public class AddScore : MonoBehaviour
{

    //Upon colliding with an object's score colider, the score
    //is increased together with the maximum velocity of the ball
    private void OnTriggerExit(Collider other)
    {
        GameManager.score++;
        PlayerControl.maxVelocity += 1.5f;
    }
}

