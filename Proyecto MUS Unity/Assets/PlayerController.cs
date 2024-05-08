using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed = 10.0f;
    [SerializeField]
    private float _gravity = -9.8f;
    [SerializeField]
    private float _cameraSpeed = 10.0f;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float xForce = Input.GetAxis("Horizontal") * _playerSpeed * Time.deltaTime;
        float zForce = Input.GetAxis("Vertical") * _playerSpeed * Time.deltaTime;
        Vector3 dir = new Vector3(xForce, _gravity * Time.deltaTime, zForce);

        gameObject.GetComponent<CharacterController>().Move(dir);

        float mouseDeltaX = Input.GetAxis("Mouse X") * _cameraSpeed * Time.deltaTime;
        //float mouseDeltaY = Input.GetAxis("Mouse Y") * _cameraSpeed * Time.deltaTime;
        gameObject.transform.Rotate(Vector3.up, mouseDeltaX);

    }
}
