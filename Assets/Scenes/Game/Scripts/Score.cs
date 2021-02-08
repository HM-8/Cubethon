using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = Convert.ToString(0);
        //scoreText.text = Convert.ToString(Convert.ToInt32(player.position.z));
        scoreText.text = player.position.z.ToString("0");

    }
}
