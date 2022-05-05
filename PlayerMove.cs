using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public Camera cam;
    void Start()
    {
       
    }

    
    void Update()
    {
        getMoveObject();
    }
    public void getMoveObject()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
                
    }
}
