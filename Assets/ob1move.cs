using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob1move : MonoBehaviour
{
    public float movingspeed = 8;
    public float deadzone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movingspeed)*Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
