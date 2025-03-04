using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMV : MonoBehaviour
{
    [Header("Sensitivity")]
    public float sensitivity = 100.0f;
    
    [Header("Player Body")]
    public Transform playerBody;

    [Header("Max Rotation")]
    public float maxRotY = 90.0f;
    public float minRotY = -90.0f;

    private float rotX = 0.0f;

    void Update()
    {    
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, minRotY, maxRotY);

        transform.localRotation = Quaternion.Euler(rotX, 0.0f, 0.0f);
        playerBody.Rotate(Vector3.up * mouseX);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
