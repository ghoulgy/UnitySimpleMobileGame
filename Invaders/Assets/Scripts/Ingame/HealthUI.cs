using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthUI : MonoBehaviour {

    public GameObject UIgameover;
    public Sprite[] Health;
    public Image Heart;
    public int MaxHealth = 5;
	// Use this for initialization
	void Start () {
        UIgameover.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Heart.sprite = Health[MaxHealth];
        if (MaxHealth <= 0)
        {
            UIgameover.SetActive(true);
        }
	}
}
