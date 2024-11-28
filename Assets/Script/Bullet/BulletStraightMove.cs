using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 直進する弾の移動クラス
/// </summary>
public class BulletStraightMove : iBulletMove
{
    private float speed = 10f; // 速度を設定

    public void Move(GameObject bullet)
    {
        StraightMove(bullet);
    }

    private void StraightMove(GameObject bullet)
    {
        bullet.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}