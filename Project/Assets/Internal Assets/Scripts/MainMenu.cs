using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Image ProgressBar;

    public void StartPlay() {
        StartCoroutine(Progress());
    }

    public void Exit() {
        Application.Quit();
    }

    public IEnumerator Progress() {

        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        while (!operation.isDone) {
            ProgressBar.fillAmount = operation.progress;
            yield return null;
        }
    }
}
