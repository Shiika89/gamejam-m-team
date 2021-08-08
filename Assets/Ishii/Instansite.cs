using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instansite : MonoBehaviour
{
    [SerializeField] GameObject m_gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(m_gameManager, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
