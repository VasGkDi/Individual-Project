
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Game is exiting..."); // This will show in the Console when running in the Editor.
        Application.Quit();
    }
}