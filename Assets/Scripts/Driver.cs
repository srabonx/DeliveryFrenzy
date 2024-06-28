using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float steerDir = Input.GetAxis("Horizontal") * m_steerSpeed * Time.deltaTime;
        float moveDir = Input.GetAxis("Vertical") * m_moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerDir);
        transform.Translate(0, moveDir, 0);
        
    }

    [SerializeField] private float m_steerSpeed = 200f;
    [SerializeField] private float m_moveSpeed = 20f;
}
