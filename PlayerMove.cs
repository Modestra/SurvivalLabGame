using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    Rigidbody body;
    public float rotateSpeed = 15f;
    public float jumpforce = 100f;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
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
            body.useGravity = false;
            transform.Translate(Vector3.forward * rotateSpeed * Time.deltaTime);
            body.useGravity = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            body.useGravity = false;
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
            body.useGravity = true;
        }
    }
    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            body.AddForce(Vector3.up * jumpforce);
        }
    }
}
