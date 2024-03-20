using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;

    //This method starts the coroutine of loading any given scene

    public void LoadScene(int levelIndex)
    {
        StartCoroutine(LoadLevel(levelIndex));
        //SceneManager.LoadScene("INGAME");
    }

    //This Enumerator loads the scene entered in LoadScene() and
    //starts the fade transition

    IEnumerator LoadLevel (int levelIndex)
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadSceneAsync(levelIndex);
    }
}
