using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingController : MonoBehaviour
{
    public float distanceToSee = 50f;
    RaycastHit hit;

    // Update is called once per frame
    public void OnFire(InputValue value)
    {
        
        Debug.DrawRay(transform.position, transform.forward * distanceToSee, Color.red);
        // if spacebar is pressed

        if (Physics.Raycast(transform.position, transform.forward, out hit, distanceToSee))
        {
            if (hit.collider.gameObject.tag == "enemy")
            {
                Debug.Log("enemy");
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
