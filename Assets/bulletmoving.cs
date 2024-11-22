using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmoving : MonoBehaviour
{
    public float movingspeed = 8;
    public float deadzone = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * movingspeed) * Time.deltaTime;
        if (transform.position.x > deadzone)
        {
            Destroy(gameObject);
        }
    }
}
