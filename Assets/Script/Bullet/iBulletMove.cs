using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾の移動方法を実装するインターフェース
/// </summary>
public interface iBulletMove
{
    void Move(GameObject bullet);
}