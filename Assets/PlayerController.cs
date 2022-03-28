using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 10f;
    public float maxXDist = 10f;

    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        // get the horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // if the player is too far to the left or right, move them back to the side
        if (transform.position.x < -maxXDist)
        {
            transform.position = new Vector3(-maxXDist, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > maxXDist)
        {
            transform.position = new Vector3(maxXDist, transform.position.y, transform.position.z);
        }

        // if the player presses the spacebar, shoot a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate a projectile
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
        
    }
}
