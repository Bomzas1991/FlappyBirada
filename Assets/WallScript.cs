using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public float speed;
    public float startX;
    public float endX;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;

        startX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x;
        startX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        float x = transform.position.x;

        if (x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
