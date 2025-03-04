using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMV : MonoBehaviour
{
    public float speed = 10.0f;
    public Transform cameraTransform;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 mvment = new Vector3(horizontal, 0.0f, vertical);

        mvment = cameraTransform.TransformDirection(mvment);
        mvment.y = 0;
        
        transform.Translate(mvment * speed * Time.deltaTime, Space.World);

        //Game quit on Escape
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
