using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner1 : MonoBehaviour
{
    public GameObject ob1;
    public float spawnrate = 6;
    private float timer = 0;
    //private float timerdif = 0;
    public float ranhight = 8;
    public logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
        spawncode();
       
    }
    // Update is called once per frame
    void Update()
    {       
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }   else
        {
            spawncode();
        }
    }
    void spawncode()
    {
        float lowest = transform.position.y - ranhight;
        float highest = transform.position.y + ranhight;
        Instantiate(ob1, new Vector3(transform.position.x,Random.Range(lowest,highest),0), transform.rotation);
        timer = 0;
    }
}
