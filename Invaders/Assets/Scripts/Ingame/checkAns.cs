using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class checkAns : MonoBehaviour {

    public GameObject Lazer, AlienLaser;
    public Transform ShotSpawn;
    public string[] optr = {"+", "-", "x", "÷"};
    private RandomNum floatScript;
    public ShooterSpawn shooterScript;
    private GameObject alienspawn, shooterSpawn;
    private Text answer, questions1, questions2, operators, scores;
    private double danswer, dquestions1, dquestions2, result;
    private int scoreValue = 0;

    // Use this for initialization
    void Start () {
        alienspawn = GameObject.FindGameObjectWithTag("Respawn");
        floatScript = alienspawn.GetComponent<RandomNum>();
        shooterSpawn = GameObject.FindGameObjectWithTag("ShooterRespawn");
        shooterScript = shooterSpawn.GetComponent<ShooterSpawn>();
        answer = GameObject.Find("my_ans").GetComponent<Text>();
        questions1 = GameObject.Find("QuestionsNum1").GetComponent<Text>();
        questions2 = GameObject.Find("QuestionsNum2").GetComponent<Text>();
        operators = GameObject.Find("Operators").GetComponent<Text>();
        scores = GameObject.Find("ScoreValue").GetComponent<Text>();
        
        // Initialize Random number
        questions1.text = (Random.Range(1, 9)).ToString();
        operators.text = optr[Random.Range(0, 3)];
        questions2.text = (Random.Range(1, 9)).ToString();
    }

    // Update is called once per frame
    void Update () {
        
    }

    public void onClick()
    {
        if (answer.text != "")
        {
            danswer = double.Parse(answer.text);
            dquestions1 = double.Parse(questions1.text);
            dquestions2 = double.Parse(questions2.text);
            string optr = operators.text;
            switch (optr)
            {
                case "+":
                    result = dquestions1 + dquestions2;
                    break;
                case "-":
                    result = dquestions1 - dquestions2;
                    break;
                case "x":
                    result = dquestions1 * dquestions2;
                    break;
                case "÷":
                    result = dquestions1 / dquestions2;
                    break;
            }

            Debug.Log("Answer : " + danswer + " Question: " + dquestions1 + optr + dquestions2);
            Debug.Log("Results: " + result);

            if (danswer == result)
            {
                Debug.Log("Answer Correct!");
                if (floatScript.foeCount > 0) Instantiate(Lazer, ShotSpawn.position, ShotSpawn.rotation);
                questions1.text = (Random.Range(1, 9)).ToString();
                questions2.text = (Random.Range(1, 9)).ToString();
                scoreValue++;
                scores.text = scoreValue.ToString();
            }
            else
            {
                Debug.Log("Answer Wrong!");
                if (floatScript.foeCount > 0)
                {
                    Instantiate(AlienLaser, shooterScript.alienshootclone.transform.position, shooterScript.alienshootclone.transform.rotation);
                }
            }
        }
        answer.text = "";
    }
}
