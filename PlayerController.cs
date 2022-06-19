using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontal;
    public float speed = 10.0f;
    private float xRange = 10.0f;
    public GameObject preferencePrefub;
    void Start()
    {
        
    }

    void LateUpdate()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontal * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(preferencePrefub, transform.position, transform.rotation);
        }
    }
}
