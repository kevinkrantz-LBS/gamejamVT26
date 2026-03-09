using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


    public class LogicScript : MonoBehaviour
    {
        // håller koll på spelarens poäng
        public int playerScore;

        // referens till texten som visar score på skärmen
        public Text scoreText;

        // game over UI som visas när man dör
        public GameObject gameOverScreen;

        // denna funktion körs när spelaren får poäng
        public void addScore(int scoreToAdd)
        {
            // lägger till poäng
            playerScore = playerScore + scoreToAdd;

            // uppdaterar texten så rätt score visas
            scoreText.text = playerScore.ToString();
        }

        // körs när spelaren dör
        public void gameOver()
        {
            // gör så game over screen syns
            gameOverScreen.SetActive(true);
        }

        // startar om spelet
        public void restartGame()
        {
            // laddar om samma scen igen
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }