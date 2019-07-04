using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{

    public int Score = 0;
    public float Health = 100;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Bonus") {
            Score += 1;
            Destroy(col.gameObject);
            GameObject bonus = Instantiate(Resources.Load("bonus_Pickup")) as GameObject;
            bonus.transform.position = col.gameObject.transform.position;
        }
    }

}
