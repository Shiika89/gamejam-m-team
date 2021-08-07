using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Direction : MonoBehaviour
{
    [SerializeField] float m_directionSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal2");
        float z = Input.GetAxis("Vertical2");

        if ((x != 0) || (z != 0))
        {
            var direction = new Vector3(0, 0, x + z);
            transform.localRotation = Quaternion.LookRotation(direction);
        }
    }
}
