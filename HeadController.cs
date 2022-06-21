using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    public float xPos, yPos;
    public GameObject head;
    void Start()
    {
        
    }

    void Update()
    {
        xPos += Input.GetAxis("Mouse X");
        yPos += Input.GetAxis("Mouse Y");
        head.transform.rotation = Quaternion.Euler(-yPos,xPos,0);
        transform.rotation = Quaternion.Euler(-yPos, xPos, 0);
    }
}
