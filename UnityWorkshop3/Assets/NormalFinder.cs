using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalFinder : MonoBehaviour
{
    public float floatheight = 1;

    // FixedUpdate is called once per frame
    private void FixedUpdate()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, -transform.up, Color.red);
        Ray ray = new Ray(transform.position, -transform.up);
        if (Physics.Raycast(ray, out hit, floatheight))
        { 
              transform.position = hit.point + (transform.up * floatheight);
              transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
                
        }
    }

}

