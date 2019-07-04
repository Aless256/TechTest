using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public Transform Target;
    private Vector3 StartPos;

    // Use this for initialization
    void Start()
    {
        StartPos = gameObject.transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, Target.transform.position + StartPos, MoveSpeed * Time.deltaTime);
            //gameObject.transform.LookAt(Target.transform);
        }
    }
}
