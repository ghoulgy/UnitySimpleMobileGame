using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnterNewGame : MonoBehaviour {

	// Use this for initialization
    public void NewGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
