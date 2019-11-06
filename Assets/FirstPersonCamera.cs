
using UnityEngine;
using System.Collections;

public class FirstPersonCamera : MonoBehaviour
{

    public float speed = 2.0f;
    public float speedf = 30f;

    void Update()
    {
        //Camera Rotate
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-speedf * Time.deltaTime, 0, 0), Space.Self);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -speedf * Time.deltaTime, 0), Space.Self);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(speedf * Time.deltaTime, 0, 0), Space.Self);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, speedf * Time.deltaTime, 0), Space.Self);
        }
         new WaitForSeconds(1);

    }
}