using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //UNITY PHYSICS is prefered in FixedUpdate instead of Update() or Start()
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.left * Time.deltaTime * 8f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.right * Time.deltaTime * 8f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.back * Time.deltaTime * 8f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.forward * Time.deltaTime * 8f;
        }
    }

}
