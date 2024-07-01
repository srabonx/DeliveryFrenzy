using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
     bool m_hasPackage = false;

     [SerializeField]Color32 m_hasPackageColor = new Color32(243,237,0,255);

     [SerializeField]Color32 m_noPackageColor = new Color32(255,255,255,255);
     [SerializeField] float m_destroyTime = 0.2f;

     SpriteRenderer m_spriteRenderer;

     
     void Start()
     {
          m_spriteRenderer = GetComponent<SpriteRenderer>();
     }

   private void OnCollisionEnter2D(Collision2D other)
   {
     
   }

   private void OnTriggerEnter2D(Collider2D other) 
   {
        if(other.tag == "Package" && !m_hasPackage)
        {
           m_hasPackage = true;
           Destroy(other.gameObject, m_destroyTime);
           m_spriteRenderer.color = m_hasPackageColor;
        }
        else if(other.tag == "DeliverySpot" && m_hasPackage)
        {
          m_hasPackage = false;
           m_spriteRenderer.color = m_noPackageColor;
        }
          
   }   
}
