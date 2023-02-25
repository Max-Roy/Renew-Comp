using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float moveSpeed;
    public float topBarrier;
    public float botBarrier;
    public float leftBarrier;
    public float rightBarrier;
  
    void Update()
    {
        if(Input.mousePosition.y >= Screen.height * topBarrier && transform.position.y < 6.5f)
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed, Space.World);
        }

        if (Input.mousePosition.y <= Screen.height * botBarrier && transform.position.y > -14.5f)
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed, Space.World);
        }

        if (Input.mousePosition.x >= Screen.width * rightBarrier && transform.position.x < 17.1f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
        }

        if (Input.mousePosition.x <= Screen.width * leftBarrier && transform.position.x > -15.5)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
        }
    }
}
