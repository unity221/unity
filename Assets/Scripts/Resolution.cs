using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Resolution : MonoBehaviour
{
    void Update() { }

    public void SetQuality()
    {
        SetScreenResolution();
    }

    void SetScreenResolution()
    {
        string index = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (index)
        {
            case "0":
                Screen.SetResolution(2560, 1440, true);
                break;
            case "1":
                Screen.SetResolution(1920, 1080, true);
                break;
            case "2":
                Screen.SetResolution(1200, 800, true);
                break;
            case "3":
                Screen.SetResolution(900, 688, true);
                break;
            default:
                Screen.SetResolution(2560, 1440, true);
                break;
        }
    }
}
