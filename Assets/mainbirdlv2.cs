using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mainbirdlv2 : MonoBehaviour
{
    public Rigidbody2D birdrigidboby;
    public float strength;
    public logicscriptlv2 logiclv2;
    public bool birdisalive = true;
    public Text finalscore;
    // Start is called before the first frame update
    void Start()
    {
        logiclv2 = GameObject.FindGameObjectWithTag("logiclv2").GetComponent<logicscriptlv2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10)
        {
            Debug.Log("offmap");
            logiclv2.gameover();
            birdisalive = false;

        }
        if (transform.position.y >= 10)
        {
            Debug.Log("offmap");
            logiclv2.gameover();
            birdisalive = false;

        }
        if (birdisalive == true)
        {
            if ((Input.GetKeyDown(KeyCode.W) == true))
            {
                birdrigidboby.velocity = Vector2.up * strength;
            }
            if ((Input.GetKeyDown(KeyCode.Space) == true))
            {
                birdrigidboby.velocity = Vector2.up * strength;
            }
            if ((Input.GetKeyDown(KeyCode.S) == true))
            {
                birdrigidboby.velocity = Vector2.down * strength;
            }
            if ((Input.GetKeyDown(KeyCode.A) == true))
            {
                birdrigidboby.velocity = Vector2.left * strength;
            }
            if ((Input.GetKeyDown(KeyCode.D) == true))
            {
                birdrigidboby.velocity = Vector2.right * strength;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logiclv2.gameover();
        finalscore.text = logiclv2.playerscorelv2.ToString();
        birdisalive = false;

    }
}
