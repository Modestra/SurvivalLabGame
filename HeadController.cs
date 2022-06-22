using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    public float xPos, yPos;
    public GameObject head;
    private float horizontal, vertical;
    void Start()
    {
        
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        xPos += Input.GetAxis("Mouse X");
        yPos += Input.GetAxis("Mouse Y");
        head.transform.rotation = Quaternion.Euler(-yPos,xPos,0);
        transform.rotation = Quaternion.Euler(-yPos, xPos, 0);
        transform.Translate(Vector3.forward * Time.deltaTime * 10 * vertical);
        transform.Rotate(Vector3.up, Time.deltaTime * 10 * horizontal);
    }
}
public class PlayerTouch
{
    Ray ray;
    RaycastHit hit;
    public void MouseTouch()
    {
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(Input.mousePosition, Vector3.forward*1000, Color.red);
        }
    }
}
