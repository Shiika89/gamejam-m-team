using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    //hpを他のスクリプトから持ってくる
    int hp_jikken= 5;
    //ダメージいじれるようにする
    [SerializeField] int damage_jikken = 1;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            //playerのHPからダメージ文を引く
            hp_jikken -= damage_jikken;
            Debug.Log(hp_jikken);
        }
    }
}
