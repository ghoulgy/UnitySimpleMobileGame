using UnityEngine;
using System.Collections;

public class collisionDect : MonoBehaviour {

    public GameObject explode, explodeClone;
    private GameObject alienspawn, shooterspawn;
    private RandomNum floatScript; 
    private ShooterSpawn shooterScript;
    private bool delClone = true;

    // Use this for initialization
    void Start () {
        alienspawn = GameObject.FindGameObjectWithTag("Respawn");
        floatScript = alienspawn.GetComponent<RandomNum>();
        shooterspawn = GameObject.FindGameObjectWithTag("ShooterRespawn");
        shooterScript = shooterspawn.GetComponent<ShooterSpawn>();
    }
	
	// Update is called once per frame
	void Update () {
        // if (lazerInRange) Destroy(gameObject);
	}

    //Collision Detection
    void OnTriggerEnter2D(Collider2D other)
    {
        // lazerInRange = true;
        if (other.tag == "Lazer")
        {
            explodeClone = Instantiate(explode, transform.position, transform.rotation) as GameObject;
            Destroy(gameObject);
            Destroy(shooterScript.alienshootclone);
            floatScript.foeCount -= 1;
        }
    }
}
