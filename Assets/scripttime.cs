using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // IMPORTANT!!!!!!!!

public class scripttime : MonoBehaviour
{

    public Text scoreText;  // public if you want to drag your text object in there manually
    static int counter;

    void Start()
    {

        scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts

    }

    void Update()
    {

        scoreText.text = "info:" + buttontime.count;
    }
}