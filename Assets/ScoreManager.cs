using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{   
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;

    int score = 0;
    
    private void Awake() {
        instance = this;
    }

    void Start() {
        updateText();
    }

    private void updateText() {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddPoint() {
        score = score + 100;
        updateText();
    }

    public void Reset() {
        score = 0;
        updateText();
    }
}
