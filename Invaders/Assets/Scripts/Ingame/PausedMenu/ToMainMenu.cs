using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ToMainMenu : MonoBehaviour {
    private GameObject bolUpdate;
    public RandomNum _update;

    void Start()
    {
        bolUpdate = GameObject.FindGameObjectWithTag("Respawn");
        _update = bolUpdate.GetComponent<RandomNum>();
    }
    // Use this for initialization
    public void NewGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
