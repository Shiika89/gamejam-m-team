using UnityEngine;

public class Bomb : MonoBehaviour
{

    [SerializeField]
    private float _hitpoint = 1;　//ボムの耐久値

    [SerializeField]
    private float _scale_x = 10;　//ボムの大きさ(x)

    [SerializeField]
    private float _scale_y = 10;　//ボムの大きさ(y)
    

    void Start()
    {
        transform.localScale = new Vector3(_scale_x, _scale_y, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet") //Bulletが当たった時
        {
            Destroy(this.gameObject); //ボム破壊
        }
        else if (collision.tag == "BombBullet") //BombBulletが当たった時
        { 
            _hitpoint--;　//hitpoint -1

            if (_hitpoint <= 0) //hitpointが0以下の時
            {
                Destroy(this.gameObject); //ボム破壊
            }

            Debug.Log(_hitpoint);
        }

    }
    void Update()
    {

    }

}
