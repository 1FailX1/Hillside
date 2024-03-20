using UnityEngine;

public class Score : MonoBehaviour
{

    //Every frame, the score object is updated to the current score
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = GameManager.score.ToString();
    }
}
