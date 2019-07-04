using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ToGame());
    }

    IEnumerator ToGame() {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(2);
    }
}
