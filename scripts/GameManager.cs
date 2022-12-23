using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public runnerplayer player;
    public int coins = 0;
    public int life = 2;
    //bool playerdie = false;
    public Text coinstotal;
    public Text Score;
    bool dead = false;
    public GameObject[] Lifeimg;
    public GameObject gameOver;
    public GameObject YouWon;
   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<runnerplayer>();
    }

    // Update is called once per frame
    public void Coinsys()
    {
        coins++;
        coinstotal.text = ("$" + coins.ToString());
        player.collectcoin();
        if(coins == 100){
            YouWon.SetActive(true);
            Time.timeScale = 0.01f;
        }
    }
    public void Lifesys()
    {
        if(life == 0){
            dead = true;
            playerdie();
            player.deads();
        }
        Lifeimg[life].SetActive(false);
        life--;

    }
    void playerdie()
    {
        gameOver.gameObject.SetActive(true);
        Score.text = ("score = $" + coins.ToString());
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void next(){
       int i = Random.Range(0,5);
       int thisindex = SceneManager.GetActiveScene().buildIndex;
       if(thisindex == i) {
        next();
       }
       else{
       SceneManager.LoadScene(i);}
       Time.timeScale = 1f;
    }
}
