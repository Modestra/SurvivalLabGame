using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float rotatespeed;
    private float horizontal;
    private float vertical;
    public GameObject player;
    public float x, y, z;
 
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        getMoveObject();
        Jump();
    }
    public void getMoveObject()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, Time.deltaTime * rotatespeed * horizontal);
        transform.Translate(Vector3.right * speed * vertical);
        player.transform.position = transform.position + new Vector3(x,y,z);
        player.transform.rotation = transform.rotation * Quaternion.Euler(0,90,0);
    }
    public void Jump()
    {
        
    }
}
