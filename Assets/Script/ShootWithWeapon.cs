using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithWeapon : MonoBehaviour
{
    [SerializeField] private new Camera camera;
    void Update()
    {
        
    }

    public void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Shoot");
        }
    }
}