using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson2 : MonoBehaviour
{
    void Start()
    {
        string name = "Ahmed"; // for string -- primitive data type -> يعني بسيطة
        int score = 5; // int = 32bit = 4 byte
        double health = 1.5; // float/int = 64bit = 8 byte / حتى 15 خانة بعد الفاصلة
        float speed = 1.4f; //  float/int = 32bit = 4 byte / حتى 5 خانات فقط بعد الفاصلة
        bool isPlayerDead = true; // for true or false --> small والافضل استخدام اول الكلمة , - , Spaceممنوع ال  
        int mark = 95;
        // Debug.Log((5 + 1) * 3);
        // Debug.Log((5 + 1) * (3+1));
        // Debug.Log(5 + 4 * 3 - 1);

        // Debug.Log(-score);
        // Debug.Log(score);
        // Debug.Log(++score);
        // Debug.Log(score);
        // Debug.Log(--score);

        // if (mark >= 90)
        // {
        //     Debug.Log("Ahmed Is Shater :) ");
        // }
        // else if (mark >= 80)
        // {
        //     Debug.Log("Ahmed Is Good ");
        // }
        // else 
        // {
        //     Debug.Log("Ahmed Is Kaslan :(");
        // }

        while (mark >= 90)
        {
            Debug.Log("Ahmed Is Shater ");
            Debug.Log(mark--);
        }




    }

}
