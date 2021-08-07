using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float m_bulletSpeed = 1;
    [SerializeField] GameObject m_gb;

    private Rigidbody2D m_rb;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        Vector3 h = m_gb.transform.up.normalized * m_bulletSpeed;
        m_rb.velocity = h;
    }
}
