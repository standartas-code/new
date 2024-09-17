using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += new Vector3(-(speed * Time.deltaTime), 0, 0);
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, 0, -(speed * Time.deltaTime));
        //}

        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");
        transform.position = new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }
}
