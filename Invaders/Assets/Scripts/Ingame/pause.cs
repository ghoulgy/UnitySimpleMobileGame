using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

    public GameObject UIpause;
	// Use this for initialization
	void Start () {
        UIpause.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Time.timeScale = 0;
        UIpause.SetActive(true);
    }
}
