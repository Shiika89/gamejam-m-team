using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    [SerializeField] GameObject m_bullet;
    [SerializeField] GameObject m_gb;
    [SerializeField] float m_bulletSpeed = 1;
    [SerializeField] float m_interval;
    float m_timar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_timar += Time.deltaTime;
        if (m_timar > m_interval)
        {
            if (m_bullet)
            {
                var bullet = Instantiate(m_bullet, transform.position, Quaternion.identity);
                Vector3 shotForward = Vector3.Scale((transform.position - m_gb.transform.position), new Vector3(1, 1, 0)).normalized;
                bullet.GetComponent<Rigidbody2D>().velocity = shotForward * m_bulletSpeed;
            }

            m_timar = 0;
        }
    }
}
