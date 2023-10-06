using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Test : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;

        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);

        if (Physics.Raycast(ray, out hitData))
        {
            
            Debug.Log(hitData.collider.name);
        }
    }
}