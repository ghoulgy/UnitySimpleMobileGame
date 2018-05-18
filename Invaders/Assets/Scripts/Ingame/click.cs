using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class click : MonoBehaviour {

    // public GameObject red, red2, yellow, yellow2, MainCamera;
    // Use this for initialization
    private Text answer;

    void Start()
    {
        answer = GameObject.Find("my_ans").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Pressed left click, casting ray.");
            CastRay();
        }
    }

    void CastRay()
    {
        Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
        if (hitInfo)
        {
            if (hitInfo.collider.gameObject.name == "clear")
            {
                Debug.Log(hitInfo.collider.gameObject.name);
                answer.text = "";
            }
            else
            {
                 Debug.Log(hitInfo.collider.gameObject.name);
                 string temp_ans = hitInfo.collider.gameObject.name;
                 answer.text += temp_ans;
            }
           
        }
    }
}
