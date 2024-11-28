using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FPSカメラのコントローラ
/// </summary>
public class CameraFPSController : MonoBehaviour
{
    private float rotationSpeed;
    [SerializeField] private Camera fpsCamera;
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

    /// <summary>
    /// カメラの延長線が何かに当たっているかどうか判定
    /// </summary>
    private void HitChecker()
    {
        Ray ray = fpsCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
        if (Physics.Raycast(ray, out hit))
        {
            this.rayHit = true;
        }else{
            this.rayHit = false;
        }
    }
}