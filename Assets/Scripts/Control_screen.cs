using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_screen : MonoBehaviour
{
    public void SetFullOrSmallscreen(bool isFullScreen){
        Screen.fullScreen = isFullScreen;
        Debug.Log(isFullScreen);
    }
}
