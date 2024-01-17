using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sphere : MonoBehaviour
{
    // git pull
    SphereCollider sphereCollider;
    
    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
      
        sphereCollider.isTrigger = true;
    }

    
    void Update()
    {
        
    }
}
