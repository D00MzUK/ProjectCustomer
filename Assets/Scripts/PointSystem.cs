using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public Text scoreText;

    public float scoreAmount;
    public float pointIncreasePerSecond;

    void Start()
    {
        scoreAmount = 0f;
        pointIncreasePerSecond = 5f;
    }

    void Update()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        scoreAmount += pointIncreasePerSecond * Time.deltaTime;
    }
}
