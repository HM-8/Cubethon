using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDealy = 2f;
    public GameObject completeLevelUI;
    public PlayerMovement movement;
    public GameObject gameOver;
    public Text scoreNumberCompleteLevel;
    public Text scoreNumberGameOver;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            FindObjectOfType<Score>().scoreText.enabled = false;
            scoreNumberGameOver.text = FindObjectOfType<Score>().scoreText.text;
            gameOver.SetActive(true);
            movement.enabled = false;
            FindObjectOfType<PlayerAudioController>().DisableAudio();
            Invoke("Restart", restartDealy);
            Debug.Log("GAME OVER!");
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        FindObjectOfType<Score>().scoreText.enabled = false;
        scoreNumberCompleteLevel.text = FindObjectOfType<Score>().scoreText.text;
        completeLevelUI.SetActive(true);
        movement.enabled = false;
        FindObjectOfType<PlayerAudioController>().DisableAudio();
        Debug.Log("Finished Level 1!");
    }
}
