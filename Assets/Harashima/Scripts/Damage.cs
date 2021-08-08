using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    //hpを他のスクリプトから持ってくる
    [SerializeField] static public int hp= 30;
    //ダメージいじれるようにする
    [SerializeField] int damage = 1;
    [SerializeField] int bom_damage = 1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {   
            //playerのHPからダメージ文を引く
            hp -= damage;
            Destroy(collision.gameObject);
            Debug.Log(hp);
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "BombBullet")
        {
            //playerのHPからダメージ文を引く
            hp -= bom_damage;
            Destroy(collision.gameObject);
            //Debug.Log(hp);
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
