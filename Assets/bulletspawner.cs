using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public GameObject bullet;
    private float timer = 0;
    private float spawnrate = 60;
    public logicscriptlv2 logiclv2;
    private float ranbelow = 1;
    //ti le ra dan cham hon so voi spawnrate(càng cao càng thap)
    private float ranabove = 0;
    //ti le ra dan nhanh hon so voi spawnrate(càng cao thì càng cao)
    // Start is called before the first frame update
    void Start()
    {
        logiclv2 = GameObject.FindGameObjectWithTag("logiclv2").GetComponent<logicscriptlv2>();
        timer = Random.Range(10, 61);
    }

    // Update is called once per frame
    void Update()
    {
        if (logiclv2.playerscorelv2 >= 20)
        {
            if (timer < spawnrate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                spawncode();
                Debug.Log("bulletout");
            }
        }
    }
    void spawncode()
    {
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 90), transform.rotation = Quaternion.Euler(0, 0, -90));
        timer = Random.Range(ranbelow,spawnrate+ranabove);
    }
}
