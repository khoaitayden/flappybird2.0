using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoversceen;
    [ContextMenu("increase score")]
    public void addscore(int scoretoadd)
    {
        playerscore+=scoretoadd;
        scoretext.text = playerscore.ToString();
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
