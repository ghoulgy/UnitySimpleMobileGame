using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class clear : MonoBehaviour {

    // Use this for initialization
    private Text answer;

	void Start () {
        answer = GameObject.Find("my_ans").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {

    }

    public void onClick()
    {
        Debug.Log("Before: " + answer.text);
        answer.text = "";
        Debug.Log("After: " + answer.text);
    }

}
