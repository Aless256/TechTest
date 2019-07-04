using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float RotateSpeed;
    public float MoveSpeed;

    private Vector3 previousLocation;
    private Vector3 currentLocation;
    private Vector3 moveDirection;

    void Start()
    {
        
    }

    void Update()
    {


        gameObject.GetComponent<CharacterController>().SimpleMove(Vector3.ClampMagnitude(new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, -1, Input.GetAxis("Vertical") * MoveSpeed), MoveSpeed));
        moveDirection.z = Input.GetAxis("Vertical");
        moveDirection.x = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            gameObject.GetComponent<Animator>().SetBool("Run", false);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("Run", true);
        }
        previousLocation = currentLocation;
        moveDirection.Normalize();
        currentLocation = previousLocation + moveDirection * MoveSpeed * Time.fixedDeltaTime;
        if ((currentLocation - previousLocation) != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(currentLocation - previousLocation), Time.fixedDeltaTime * RotateSpeed);
        }
    }

    public void GetHit() {
        gameObject.GetComponent<Animator>().Play("Hit");
    }
}
