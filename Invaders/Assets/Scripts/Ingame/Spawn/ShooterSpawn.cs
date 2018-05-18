using UnityEngine;
using System;
using System.Collections;

public class ShooterSpawn : MonoBehaviour {
    public GameObject alienshoot;
    public GameObject alienshootclone;
    private float dropSpeed = 1.0f;
    private float floatStrength = 0.25f;
    private float a_temp_pos_y;
    public bool update = true;

    // Use this for initialization
    void Start () {
        spawnShoot();
	}
	
	// Update is called once per frame
	void Update () {
        if (update)
        {
            shooterDrop();
        }
        else
        {
            Invoke("shooterFloat", 0.5f);
        }
    }

    void spawnShoot()
    {
        alienshootclone = Instantiate(alienshoot) as GameObject;
        alienshootclone.transform.position = transform.position;
    }

    void shooterDrop()
    {
        if (alienshootclone != null)
        {
            alienshootclone.transform.position += new Vector3(0, -dropSpeed * Time.deltaTime, 0);

            if (alienshootclone.transform.position.y <= 1.2f)
            {
                //Debug.Log(a.transform.position.y);
                a_temp_pos_y = alienshootclone.transform.position.y;
                dropSpeed = 0.17f;
                alienshootclone.transform.position += new Vector3(0, -dropSpeed * Time.deltaTime, 0);
                update = false;
            }
        }     
    }

    void shooterFloat()
    {
        if (alienshootclone != null)
        {
            //ufo.transform.position = new Vector3(ufo.transform.position.x, 2.492578f - ((float)Math.Sin(Time.time) * floatStrength), ufo.transform.position.z);
            alienshootclone.transform.position = new Vector3(alienshootclone.transform.position.x, a_temp_pos_y + ((float)Math.Sin(Time.time) * floatStrength), alienshootclone.transform.position.z);
        }
    }
}
