using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlescript : MonoBehaviour
{
    // Start is called before the first frame update
    public logicscript logic;
    public spawner1 spawner1;
    public ob1move ob1Move;
    void Start()
    {
        spawner1 = GameObject.FindGameObjectWithTag("spawner1").GetComponent<spawner1>();
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
        ob1Move = GameObject.FindGameObjectWithTag("ob1move").GetComponent<ob1move>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addscore(1);
            //difficult managment
            if (logic.playerscore % 5 == 0)
            {
                spawner1.spawnrate = spawner1.spawnrate - 0.3f;
                Debug.Log("increased");
            }
            if (logic.playerscore % 10 == 0)
            {
                spawner1.ranhight = spawner1.ranhight + 0.4f;
                Debug.Log("increasedhard");
            }
            ob1Move.movingspeed -= 0.04f;
            Debug.Log("speedup");


        }

    }
}
