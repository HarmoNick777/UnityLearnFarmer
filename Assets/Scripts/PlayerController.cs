using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 0.6f;

    private float movementX;

    private void OnMove(InputValue movementValue)
    {
        float movementVector = movementValue.Get<float>();
        movementX = movementVector;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0f, 0f);
        movement.Normalize();
        transform.Translate(movement * speed);
    }
}
