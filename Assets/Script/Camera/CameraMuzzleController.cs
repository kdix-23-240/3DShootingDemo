using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 銃口の視線を取得するクラス
/// </summary>
public class CameraMuzzleController : MonoBehaviour
{
    [SerializeField] private Camera muzzleCamera;
    private RaycastHit impactPoint; // 銃口の延長線が当たった場所
    [SerializeField] private bool rayHit;

    void Update()
    {
        HitChecker();
    }

    /// <summary>
    /// 銃口の延長線が何かに当たっているかどうか判定
    /// </summary>
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

    public RaycastHit GetImpactPoint()
    {
        return impactPoint;
    }
}