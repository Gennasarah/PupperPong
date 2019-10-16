using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    int score = 0; //player's current score
    [SerializeField]
    int winReq = 3; //required points to win
    [SerializeField]
    GameObject[] scoreIcons; //array of icons used in the HUD to indicate score
    

    
    void Start()
    {

      for (int i = 0; i < scoreIcons.Length; i++)
      {

          scoreIcons[i].SetActive(false);

      }

    }

    public void IncrementScore() //increases player's score and updates HUD to reflect that
    {

        if(score < winReq)
        {
            score++;
            scoreIcons[score - 1].SetActive(true);
            if(score >= winReq)
            {

                Debug.Log("YOU WIN!");

            }
        }
        
    }

}
