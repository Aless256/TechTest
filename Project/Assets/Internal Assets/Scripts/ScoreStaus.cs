using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreStaus : MonoBehaviour
{

    public GameObject Player;

    void Update()
    {
        gameObject.GetComponent<Text>().text = "Score: " + Player.GetComponent<PlayerInteraction>().Score;
    }
}
