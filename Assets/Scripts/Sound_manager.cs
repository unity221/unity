using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_manager : MonoBehaviour
{
    [SerializeField] Slider volume_slider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("music_volume"))
        {
            PlayerPrefs.SetFloat("music_volume", 1);
            Load_volume();
        }
        else
        {
            Load_volume();
        }
    }

    // Update volume
    public void Change_volume()
    {
        AudioListener.volume = volume_slider.value;
        Save_volume();
    }

    private void Load_volume(){
        volume_slider.value = PlayerPrefs.GetFloat("music_volume");
    }

    private void Save_volume(){
        PlayerPrefs.SetFloat("music_volume", volume_slider.value);
    }
}
