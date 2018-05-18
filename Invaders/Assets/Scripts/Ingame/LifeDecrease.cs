using UnityEngine;
using System.Collections;

public class LifeDecrease : MonoBehaviour {
    private GameObject alienspawn, shooterSpawn, health;
    public HealthUI healthScript;
    // Use this for initialization
    void Start () {
        health = GameObject.FindGameObjectWithTag("Live");
        healthScript = health.GetComponent<HealthUI>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // lazerInRange = true;
        if (other.tag == "AlienLazer")
        {
            healthScript.MaxHealth -= 1;
        }
    }
}
