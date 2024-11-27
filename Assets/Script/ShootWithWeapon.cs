using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithWeapon : MonoBehaviour
{
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CameraMuzzleController muzzleController = transform.Find("FPSCamera").Find("SniperRifle").Find("MuzzleCamera").gameObject.GetComponent<CameraMuzzleController>();
             if (muzzleController.GetRayHit())
            {
                Transform hitTransform = muzzleController.GetImpactPoint().transform;
                if (hitTransform.tag == "Enemy")
                {
                    Transform grandParentTransform = hitTransform.parent?.parent;
                    if (grandParentTransform != null)
                    {
                        Destroy(grandParentTransform.gameObject);
                    }
                }
            }
        }
    }
}