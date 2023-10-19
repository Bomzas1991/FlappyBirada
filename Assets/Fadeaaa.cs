using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadeaaa : MonoBehaviour
{
    SpriteRenderer renderer;
    public float secons;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var color = renderer.color;
        color.a -= Time.deltaTime * secons;

        renderer.color = color;
    }
}
