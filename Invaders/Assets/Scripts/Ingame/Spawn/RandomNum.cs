using UnityEngine;
using System;
using System.Collections;

public class RandomNum : MonoBehaviour {
    public GameObject[] ufos;
    private float dropSpeed = 1.0f;
    private float floatStrength = 0.25f;
    private GameObject ufo;
    public static bool update = true; 
    public bool initial_val = true;
    public int foeCount = 0;
    public Vector3 initial_pos;
    public GameObject spawnLoc;
    private float temp_pos_y;

    // Use this for initialization
    void Start() {
        spawnUFO();
    }
    
    // Update is called once per frame
    void Update() {

        if (foeCount <= 0)
        {
            spawnUFO2();
            ufoDrop();
        }

        ufoDrop();           
    }



    public void ufoFloat()
    {
        if (ufo != null)
        {
            //ufo.transform.position = new Vector3(ufo.transform.position.x, 2.492578f - ((float)Math.Sin(Time.time) * floatStrength), ufo.transform.position.z);
            //ufo.transform.position = new Vector3(spawnLoc.transform.position.x, temp_pos_y + ((float)Math.Sin(Time.time) * floatStrength), spawnLoc.transform.position.z);
        }
    }

    public void ufoDrop()
    {
        if(ufo != null)
        {
            ufo.transform.position += new Vector3(0, -dropSpeed * Time.deltaTime, 0);

            if (ufo.transform.position.y <= 2.5f)
            {
                dropSpeed = 0;
                ufo.transform.position += new Vector3(0, -dropSpeed * Time.deltaTime, 0);
            }
        }
    }

    public void spawnUFO()
    {
        int rndNum = UnityEngine.Random.Range(0, ufos.Length);
        ufo = Instantiate(ufos[rndNum]) as GameObject;
        ufo.transform.position = transform.position;
        Debug.Log(transform.position);
        foeCount += 1;
        ufoDrop();
    }

    public void spawnUFO2()
    {
        dropSpeed = 1.0f;
        int rndNum = UnityEngine.Random.Range(0, ufos.Length);
        ufo = Instantiate(ufos[rndNum]) as GameObject;
        ufo.transform.position = spawnLoc.transform.position;
        foeCount += 1;
        ufoDrop();
    }
}

