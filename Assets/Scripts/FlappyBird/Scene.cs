using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour{
    Score score;

    void OnEnable(){
        Debug.Log("Start");
    }

    public void Restartlevel(){
        Debug.Log("End");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
