using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScene : MonoBehaviour 
{
    public void startGame()
    {
        SceneManager.LoadScene("SavannaLevel");
    }
    public void replayGame()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
