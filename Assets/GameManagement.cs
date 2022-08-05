using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 3f;

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
        }

    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}   