using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFPSController : MonoBehaviour
{
    private float rotationSpeed;
    [SerializeField] private Camera camera;
    Vector3 impactPoint;
    [SerializeField] private bool rayHit;

    void Start()
    {
        rotationSpeed = GameSystemController.GetInstance().GetCameraFPSSpeed();
    }
    void Update()
    {
        Rotate();
        HitChecker();
    }

    public void RotateUp()
    {
        transform.Rotate(Vector3.right, -rotationSpeed * Time.deltaTime);
    }

    public void RotateDown()
    {
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }

    public void Rotate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            RotateUp();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            RotateDown();
        }
    }

    private void HitChecker()
    {
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
        if (Physics.Raycast(ray, out hit))
        {
            rayHit = true;
        }else{
            rayHit = false;
        }
    }

}