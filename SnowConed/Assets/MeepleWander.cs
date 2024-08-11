using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeepleWander : MonoBehaviour
{
    private Rigidbody m_rb;

    [SerializeField] private Vector3 m_wTarget = new Vector3(1, 0, 1);
    [SerializeField] private float m_wDist;
    [SerializeField] private float m_wRad;
    [SerializeField] private float m_wJitter;
    [SerializeField] private float m_speed = 20;

    private void Awake()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_rb.velocity += Vector3.forward * Time.deltaTime * m_speed;
    }

    private Vector3 Seek(Vector3 tPos)
    {
        Vector3 vel = (tPos - gameObject.transform.position).normalized;

        return (vel - m_rb.velocity);
    }

    private Vector3 Wander()
    {
        return new Vector3();
    }
}
