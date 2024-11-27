using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMuzzleController : MonoBehaviour
{
    [SerializeField] private Camera camera;
    Vector3 impactPoint;
    [SerializeField] private bool rayHit;
    void Update()
    {
        HitChecker();
    }

    private void HitChecker()
    {
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);
        if (Physics.Raycast(ray, out hit))
        {
            rayHit = true;
        }else{
            rayHit = false;
        }
    }

}