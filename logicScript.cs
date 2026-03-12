using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    private bool isGameOver = false;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        isGameOver = true;
    }

    void OnGUI()
    {
        GUIStyle labelStyle = new GUIStyle();
        labelStyle.fontSize = 50;
        labelStyle.normal.textColor = Color.white;
        labelStyle.alignment = TextAnchor.MiddleCenter;

        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.fontSize = 40;

        // always show score at top
        GUI.Label(new Rect(Screen.width / 2 - 150, 10, 300, 100), "Score: " + playerScore, labelStyle);

        // show game over screen
        if (isGameOver)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 100, 300, 100), "Game Over!", labelStyle);

            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 20, 200, 70), "Play Again", buttonStyle))
            {
                restartGame();
            }
        }
    }
}