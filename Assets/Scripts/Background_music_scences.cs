using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_music_scences : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] music_object = GameObject.FindGameObjectsWithTag("GameMusic");
        if (music_object.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
