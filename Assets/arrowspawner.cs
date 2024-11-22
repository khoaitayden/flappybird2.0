using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowspawner : MonoBehaviour
{
    public GameObject arrow;
    private float timer = 0;
    private float spawnrate = 80;
    private float ranbelow = 1;
    //t? l? ra ??n ch?m h?n so voi spawnrate(càng cao càng thap)
    private float ranabove = 0;
    //t? l? ra ??n = so voi spawnrate(càng cao thì càng cao)
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(5, 15);
        if (timer < 10)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawncode();
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawncode();
        }
    }
    void spawncode()
    {
        //float lowest = spawnrate - ranmon;
        Instantiate(arrow, new Vector3(transform.position.x, transform.position.y, 90), transform.rotation = Quaternion.Euler(0, 0, 90));
        timer = Random.Range(ranbelow, spawnrate+ranabove);
    }
}
