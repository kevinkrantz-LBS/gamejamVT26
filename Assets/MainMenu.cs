using UnityEngine;
using UnityEngine.SceneManagement; // Viktigt för att kunna byta scen

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Laddar nästa scen i kön (index 1)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}