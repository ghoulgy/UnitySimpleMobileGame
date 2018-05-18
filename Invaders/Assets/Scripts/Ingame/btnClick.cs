using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class btnClick : MonoBehaviour {

    private Text answer;

    // Use this for initialization
    void Start () {
        answer = GameObject.Find("my_ans").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void onClick()
    {
        string temp_ans = EventSystem.current.currentSelectedGameObject.name;

        Debug.Log(temp_ans);
        answer.text += temp_ans;
    }
}
