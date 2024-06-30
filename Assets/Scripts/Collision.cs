using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
     bool m_hasPackage = false;
   private void OnCollisionEnter2D(Collision2D other)
   {
        Debug.Log("Bumped"); 
   }

   private void OnTriggerEnter2D(Collider2D other) 
   {
        if(other.tag == "Package" && !m_hasPackage)
        {
           Debug.Log("Package picked up!");
           m_hasPackage = true;
        }
        else if(other.tag == "DeliverySpot" && m_hasPackage)
        {
          Debug.Log("Package delivered!");
          m_hasPackage = false;
        }
          
   }
}
