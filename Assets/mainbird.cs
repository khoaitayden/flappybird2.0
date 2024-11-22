using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainbird : MonoBehaviour
{
    public Rigidbody2D birdrigidboby;
    public float strength;
    public logicscript logic;
    public bool birdisalive = true;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(transform.position.y);
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -50)
        {
            Debug.Log("offmap");
            logic.gameover();
            birdisalive = false;

        }
        if (transform.position.y >= 50)
        {
            Debug.Log("offmap");
            logic.gameover();
            birdisalive = false;

        }
        if (logic.playerscore == 100)
        {
            Debug.Log("finished");
            logic.gameover();
            birdisalive = false;
        }
        if ((Input.GetKeyDown(KeyCode.Space)==true)&&(birdisalive==true))
        {
            birdrigidboby.velocity = Vector2.up * strength;
        }
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdisalive = false;

    }
}
