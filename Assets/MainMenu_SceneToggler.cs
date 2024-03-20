using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_SceneToggler : MonoBehaviour
{
    public Button toggleMusicButton;
    public Sprite MusicEnabledSprite;
    public Sprite MusicDisabledSprite;
    public static bool musicButtonState = true;
    public void ToggleCanvas(GameObject gm)
    {
        gm.SetActive(!gm.activeInHierarchy);
    }

    private void Start()
    {
        DisplayCorrectAudioImage();
    }
    public void ToggleMusicButton()
    {
        musicButtonState = !musicButtonState;
        DisplayCorrectAudioImage();
    }
    public void DisplayCorrectAudioImage()
    {
        if (musicButtonState)
        {
            toggleMusicButton.image.sprite = MusicEnabledSprite;
        }
        else
        {
            toggleMusicButton.image.sprite = MusicDisabledSprite;
        }
    }
}
