using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscriptlv2 : MonoBehaviour
{
    public int playerscorelv2;
    public Text scoretext;
    private float timer = 0;
    public GameObject gameoversceen;
    public arrowmoving arrowspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 1)
        {
            timer += Time.deltaTime;
        }
        else
        {
            playerscorelv2++;
            timer = 0;
        }
        scoretext.text=playerscorelv2.ToString();
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        gameoversceen.SetActive(true);
    }
}
