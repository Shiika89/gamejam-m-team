using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomRotate : MonoBehaviour
{
    [SerializeField] float m_rotat;
    public bool m_fire = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, m_rotat));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            m_fire = true;
            Destroy(gameObject, 3f);
        }
    }
}
