using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttontime : MonoBehaviour
{

    public static string count;
    bool rotateStatus = false;


    public void Rotasi()
    {

        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            count = "The heart is made up of four different blood-filled areas, and each of these areas is called a chamber. There are two chambers on each side of the heart. One chamber is on the top and one chamber is on the bottom. The two chambers on top are called the atria (say: AY-tree-uh). If you're talking only about one, call it an atrium. The atria are the chambers that fill with the blood returning to the heart from the body and lungs. The heart has a left atrium and a right atrium.";
            rotateStatus = false;

        }
        else
        {
            count = "The heart is made up of four different blood-filled areas, and each of these areas is called a chamber. There are two chambers on each side of the heart. One chamber is on the top and one chamber is on the bottom. The two chambers on top are called the atria (say: AY-tree-uh). If you're talking only about one, call it an atrium. The atria are the chambers that fill with the blood returning to the heart from the body and lungs. The heart has a left atrium and a right atrium.";
        }

    }
}