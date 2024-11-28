using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 遅い直進する弾の移動クラス
/// </summary>
public class BulletSlowStraightMove : iBulletMove
{
    private float speed = 1f; // 速度を設定

    public void Move(GameObject bullet)
    {
        SlowStraightMove(bullet);
    }

    private void SlowStraightMove(GameObject bullet)
    {
        bullet.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}