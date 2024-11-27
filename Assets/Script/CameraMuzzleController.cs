using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraMuzzleController : MonoBehaviour
{
    [SerializeField] private Camera muzzleCamera;
    private RaycastHit impactPoint; // Vector3からRaycastHitに変更
    [SerializeField] private bool rayHit;

    void Update()
    {
        HitChecker();
    }

    private void HitChecker()
    {
        Ray ray = muzzleCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);
        if (Physics.Raycast(ray, out impactPoint)) // impactPointを更新
        {
            rayHit = true;
        }else{
            rayHit = false;
        }
    }

    public bool GetRayHit()
    {
        return rayHit;
    }

    public RaycastHit GetImpactPoint() // Vector3からRaycastHitに変更
    {
        return impactPoint;
    }
}