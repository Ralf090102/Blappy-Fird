using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
}