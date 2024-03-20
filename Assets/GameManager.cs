using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;
    public GameObject Canvas_ON_DEATH;
        public GameObject Speed_Up_Canvas;

    private void Start()
    {
        score = 0;
    }
    public void ON_DEATH_Canvas_activate()
    {
        Canvas_ON_DEATH.SetActive(true);
    }

    public void OnSpeedUpCollision()
    {
        StartCoroutine(ShowsSpeedUpCanavas());
    }
    IEnumerator ShowsSpeedUpCanavas()
    {
        Speed_Up_Canvas.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Speed_Up_Canvas.SetActive(false);
    }

}
