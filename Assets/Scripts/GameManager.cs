using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool ended = false;
    public float restartDelay = 1f;
    public GameObject completeUI;
    public void CompleteLevel(){
        completeUI.SetActive(true);
    }

    public void EndGame(){
        if(ended == false){
            Debug.Log("Game Over");
            ended = true;
            // restart game
            Invoke("Restart", restartDelay);
        }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
