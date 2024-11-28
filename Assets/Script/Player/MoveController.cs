using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private float speed;
    private float rotationSpeed;
    void Start()
    {
        speed = GameSystemController.GetInstance().GetPlayerSpeed();
        rotationSpeed = GameSystemController.GetInstance().GetCameraFPSSpeed();
    }

    void Update()
    {
        Move();
    }

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveBackward()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveLeft()
    {
        transform.Translate(-Vector3.right * speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void RotateLeft()
    {
        transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
    }

    public void RotateRight()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }


    public void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateRight();
        }
    }

}