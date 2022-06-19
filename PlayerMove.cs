using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    Rigidbody body;
    public float rotateSpeed = 300f;
    public float distanceSpeed = 15f;
    public float jumpforce = 100f;
    public GameObject playerHead;
    public GameObject player;
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
        float moveHorizontal = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        float moveVertical = -Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
        playerHead.transform.rotation *= Quaternion.Euler(moveVertical, moveHorizontal, 0);
        if (Input.GetKey(KeyCode.W))
        {
            body.useGravity = false;
            player.transform.Translate(Vector3.forward * distanceSpeed * Time.deltaTime);
            body.useGravity = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            body.useGravity = false;
            player.transform.Rotate(Vector3.forward * distanceSpeed * Time.deltaTime);
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
