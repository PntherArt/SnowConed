using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject m_playerObj;
    [SerializeField] private Vector3 m_buffer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0, m_playerObj.transform.position.z) + m_buffer;
    }
}
