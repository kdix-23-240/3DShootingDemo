using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾の移動方法を決定するファクトリ
/// </summary>
public class BulletFactory
{
    public iBulletMove SelectBulletMove(string bulletType)
    {
        iBulletMove bulletMove = null;
        switch (bulletType)
        {
            case "Straight":
                bulletMove = new BulletStraightMove();
                break;
            case "Slow":
                bulletMove = new BulletSlowStraightMove();
                break;
            default:
                Debug.Log(bulletType);
                Debug.LogError("バレットタイプが不正です");
                break;
        }
        return bulletMove;
    }
}