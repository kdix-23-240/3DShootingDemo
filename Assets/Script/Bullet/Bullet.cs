using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾を制御するクラス
/// </summary>
public class Bullet : MonoBehaviour
{
    [SerializeField] private float destroyTime;
    private string bulletType;
    private BulletFactory bulletFactory;

    void Start()
    {
        bulletFactory = new BulletFactory();
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        bulletFactory.SelectBulletMove(bulletType).Move(gameObject);
    }

    public void SetBulletType(string bulletType)
    {
        this.bulletType = bulletType;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Enemy")
        {
            //親の親要素から全て削除
            Transform grandParentTransform = collision.gameObject.transform.parent?.parent;
            if (grandParentTransform != null)
            {
                Destroy(grandParentTransform.gameObject);
            }
            Destroy(gameObject);
        }
    }
}