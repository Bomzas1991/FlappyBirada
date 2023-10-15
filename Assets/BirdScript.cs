using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirdScript : MonoBehaviour
{
    public float height;

    Rigidbody2D rb;
    public float rotatePower;

    public int Points;
    public TextMeshPro pointsText;
    public AudioClip clip;

    public WallScript wall;
    public GameObject endGameScreen;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //transform.position += Vector3.up * height;

            rb.velocity = Vector2.up * height;
        }

        float x = transform.position.x;

        if (x <= -6)
        {
            Destroy(gameObject);
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * rotatePower);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("PointCounter"))
        {
            Points++;
            pointsText.text = Points.ToString();
            AudioSource.PlayClipAtPoint(clip, transform.position, 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Walls"))
        {
            WallScript Wall = wall.GetComponent<WallScript>();
            Wall.speed = 0;
            height = 0;

            Invoke("ShowMenu", 0.5f);
        }
    }

    void ShowMenu()
    {
        endGameScreen.SetActive(true);
        pointsText.gameObject.SetActive(false);
    }
}
