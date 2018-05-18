using UnityEngine;
using System.Collections;

public class UFOlazerForward : MonoBehaviour {

    public float timer = 4f;
    private float maxSpeed = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
        pos += transform.rotation * velocity;
        transform.position = pos;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    //Collision Detection
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
