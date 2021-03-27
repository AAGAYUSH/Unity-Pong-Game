using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using TMpro;
using System;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;

    [Header("Player2")]
    public GameObject Player2Paddle;
    public GameObject Player2Goal;

    [Header("Score UI")]
    public Text Player1Text;
    public Text Player2Text;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored(){
        Player1Score++;
        Player1Text.text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored(){
        Player2Score++;
        Player2Text.text = Player2Score.ToString();
        ResetPosition();
    }
    private void ResetPosition(){
        ball.GetComponent<ball>().Reset();
        Player1Paddle.GetComponent<Paddle>().Reset();
        Player2Paddle.GetComponent<Paddle>().Reset();
        
        }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
