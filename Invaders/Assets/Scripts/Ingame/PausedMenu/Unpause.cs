using UnityEngine;
using System.Collections;

public class Unpause : MonoBehaviour {

    public GameObject UIresume;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        UIresume.SetActive(false);
        Time.timeScale = 1;
    }       
}
