using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
   
   [SerializeField] GameObject m_followTarget; 
    void Update()
    {
        transform.position = m_followTarget.transform.position + new Vector3(0,0,-10);
    }
}
