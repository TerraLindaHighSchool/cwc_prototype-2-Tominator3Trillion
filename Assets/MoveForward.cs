using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10f;
    public float topBound = 30f;
    public float bottomBound = -30f;

    void Update()
    {
        // move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // if the object goes too far up, destroy it
        if (transform.position.z > topBound || transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
