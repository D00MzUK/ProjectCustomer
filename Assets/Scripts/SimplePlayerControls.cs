using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerControls : MonoBehaviour
{
	public float speed = 1;
    [SerializeField]
    private float reducedSpeed;
    [SerializeField]
    private float regularSpeed;
    [SerializeField]
    private float slowDownTime;

    Rigidbody rb;
    Vector3 startPosition;

    void Start()
    {
        speed = regularSpeed;
		rb = GetComponent<Rigidbody>();
		startPosition = transform.position;
    }

    void Update()
    {
        Vector3 moveVector = new Vector3(speed - 1, 0, Input.GetAxis("Horizontal"));

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

    void OnCollisionEnter(Collision c)
    {
        float force = 3;

        if(c.gameObject.CompareTag("enemy"))
        {
            StopAllCoroutines();
            StartCoroutine(SlowDown(slowDownTime))
        }

        if (c.gameObject.tag == "enemy")
        {
            //Vector3 dir = c.contacts[0].point - transform.position;
            //dir = -dir.normalized;
            //GetComponent<Rigidbody>().AddForce(dir * force);
        }
    }

    private IEnumerator SlowDown(float time)
    {
        speed = reducedSpeed;
        yield return new WaitForSeconds(time);
        speed = regularSpeed;
    }
}
