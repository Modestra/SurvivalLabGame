using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float rotateSpeed = 15f;
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
    }
    void Update()
    {
        getMoveObject();
        Jump();
    }
    public void getMoveObject()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Rigidbody body = GetComponent<Rigidbody>();
            body.useGravity = false;
            transform.Translate(Vector3.forward * rotateSpeed * Time.deltaTime);
            body.useGravity = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rigidbody body = GetComponent<Rigidbody>();
            body.useGravity = false;
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
            body.useGravity = true;
        }
    }
    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
