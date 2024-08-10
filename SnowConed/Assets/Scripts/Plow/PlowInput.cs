using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlowInput : MonoBehaviour
{
    [SerializeField]
    private float m_speedMod;
    private PlayerControls m_input;
    private Rigidbody m_rb;
    private Vector2 m_movement;

    private void Awake()
    {
        m_input = new PlayerControls();

        m_rb = GetComponent<Rigidbody>();
        if (m_rb == null)
            Debug.LogError("No RigidBody Found on " + gameObject.name);
    }

    private void OnEnable()
    {
        m_input?.Plowing.Enable();
    }

    private void OnDisable()
    {
        m_input?.Plowing.Disable(); 
    }

    private void Update()
    {
        m_movement = m_input.Plowing.Movement.ReadValue<Vector2>();

        if (m_movement != Vector2.zero)
            gameObject.transform.right = m_rb.velocity;

        m_rb.velocity = new Vector3(m_movement.x, 0, m_movement.y) * m_speedMod;
    }
}
