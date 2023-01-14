using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBarFill;

    public void LoadScence(int scenceId){
        StartCoroutine(LoadSceneAsync(scenceId));
    }

    IEnumerator LoadSceneAsync(int scenceId){
        AsyncOperation operation = SceneManager.LoadSceneAsync(scenceId);

        LoadingScreen.SetActive(true);
        
        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

            LoadingBarFill.fillAmount = progressValue;
            yield return null;
        }
    }
}
