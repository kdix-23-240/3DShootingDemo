using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 武器で弾を撃つクラス
/// </summary>
public class ShootWithWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private  Transform muzzleCameraTransform;
    [SerializeField] private string bulletType;

    void Start()
    {
        muzzleCameraTransform = transform.Find("FPSCamera").Find("SniperRifle").Find("MuzzleCamera").transform;
    }
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //MuzzleCameraの位置に弾を生成
            GameObject bullet = Instantiate(bulletPrefab, muzzleCameraTransform.position, muzzleCameraTransform.rotation);
            bullet.GetComponent<Bullet>().SetBulletType(bulletType);
        }
    }
}