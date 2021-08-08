using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Gamepad m_gamepad = null;
    [SerializeField] float m_moveSpeed;
    [SerializeField] GameObject m_muzzle;
    Vector2 m_inputMoveAxis = Vector2.zero;
    Vector2 m_inputMoveAxis2 = Vector2.zero;
    public bool m_fire = false;
    Rigidbody2D m_rb;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_inputMoveAxis = m_gamepad.leftStick.ReadValue();
        m_inputMoveAxis2 = m_gamepad.rightStick.ReadValue();
        m_muzzle.transform.localPosition = m_inputMoveAxis2.normalized * 0.15f;
        m_rb.velocity = m_inputMoveAxis * m_moveSpeed;
        if (m_inputMoveAxis2.x != 0 || m_inputMoveAxis2.y != 0)
        {
            m_fire = true;
        }
        else
        {
            m_fire = false;
        }
    }
}
