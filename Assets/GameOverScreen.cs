using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{   
    public TextMeshProUGUI scoreText;

    public void setup(int score) {
        gameObject.SetActive(true);
        scoreText.text = "Score: " + score.ToString();
    }

    public void restartButton() {
        SceneManager.LoadScene("Snke");
    }
}
