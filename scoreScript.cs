using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public static int playerScore = 0;

    void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 50;
        style.normal.textColor = Color.white;

        GUI.Label(new Rect(10, 10, 300, 100), "Score: " + playerScore, style);
    }
}