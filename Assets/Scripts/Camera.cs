using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed = 1;

    Rigidbody rb;
    Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 moveVector = new Vector3(speed - 1, 0, 0);

        transform.Translate(moveVector * speed);
    }

    void ResetPosition()
    {
        if (rb != null)
        {
            rb.position = startPosition;
        }

        else
        {
            Debug.Log("Warning: no rigidbody attached to player");
        }
    }
}
