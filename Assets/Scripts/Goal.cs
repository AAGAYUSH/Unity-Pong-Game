using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayer1Goal;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Ball")){
            if(!isPlayer1Goal){
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
            else{
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();

            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
