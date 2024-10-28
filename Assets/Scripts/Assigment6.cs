using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigment6 : MonoBehaviour
{
    void Start()
    {
        int playerLives = 3;
        while (playerLives > 0){
            if (playerLives == 3){
                Debug.Log("Many Lives --> 3 :)");
            }
            else if (playerLives == 2){
                Debug.Log("2 lives");
            }
            else if (playerLives == 1){
                Debug.Log("The Last Lives :|");
            }
            playerLives--;
        }
        Debug.Log("Game Over!! :(");
        Debug.Log("A7");
    }
}
