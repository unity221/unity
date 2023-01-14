using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_button_on_off : MonoBehaviour
{
    [SerializeField] Image sound_on_icon;
    [SerializeField] Image sound_off_icon;
    private bool muted = false;
    void Start()
    {
        if (PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }
    
    public void onButtonPress(){
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon(){
        if (muted == true)
        {
            sound_on_icon.enabled = false;
            sound_off_icon.enabled = true;
        }
        else
        {
            sound_on_icon.enabled = true;
            sound_off_icon.enabled = false;
        }
    }

    private void Load(){
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save(){
        PlayerPrefs.SetInt("muted", muted ? 1: 0);
    }
}
