using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float m_steerSpeed = 200f;
    [SerializeField] private float m_moveSpeed = 20f;
    [SerializeField] private float m_slowSpeed = 10f;
    [SerializeField] private float m_boostSpeed = 35f;

    private float m_timePassed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        m_timePassed += Time.deltaTime;

        float steerDir = Input.GetAxis("Horizontal") * m_steerSpeed * Time.deltaTime;
        float moveDir = Input.GetAxis("Vertical") * m_moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerDir);
        transform.Translate(0, moveDir, 0);
        
        if(m_timePassed >= 5.0f)
        {
            m_moveSpeed = 20;
            m_timePassed = 0.0f;
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        m_moveSpeed = m_slowSpeed;
        m_timePassed = 0.0f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "BoostSpeed")
        {
            m_moveSpeed = m_boostSpeed;
            m_timePassed = 0.0f;
        }
    }

}
