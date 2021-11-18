using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorKamery : MonoBehaviour
{
    public float mouseSensiticity = 300f;
    public Transform playerBody;

    float xRotation = 0f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensiticity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensiticity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
