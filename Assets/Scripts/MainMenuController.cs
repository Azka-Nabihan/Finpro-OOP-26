using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public string levelToStart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        AudioManager.instance.PlayTitle();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(levelToStart);

        AudioManager.instance.PlayNextBGM();

        AudioManager.instance.PlaySFXPitchAdjusted(5);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quitting The Game");

        AudioManager.instance.PlaySFXPitchAdjusted(5);
    }
}
