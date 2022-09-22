using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
   public float rotationSpeed = 100f;
   public float movementSpeed = 20f;
   private float xMovement;
   private float yMovement;
   
   // FixedUpdate is called once per physics frame
   void FixedUpdate()
   {
       transform.Translate(0f, 0f, yMovement * Time.deltaTime * movementSpeed); 
       transform.Rotate(0f, xMovement * rotationSpeed * Time.deltaTime, 0f, Space.Self);
       
   }

   void OnMove(InputValue value)
   {    var movement = value.Get<Vector2>();
       xMovement = movement.x;
       yMovement = movement.y;
   }
}
