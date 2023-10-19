using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    SpriteRenderer renderer;
    public float secons;

    BirdScript bird;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

        bird = GetComponent<BirdScript>();
    }

    void Update()
    {

            var color = renderer.color;
            color.a -= Time.deltaTime * secons;

            renderer.color = color;
        
    }
}
