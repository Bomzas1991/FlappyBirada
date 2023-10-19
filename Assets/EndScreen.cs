using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TextMeshPro points;
    public TextMeshPro BestPoints;

    // Start is called before the first frame update
    void Start()
    {
        var score = PlayerPrefs.GetInt("Points");
        points.text = score.ToString();

        var best = PlayerPrefs.GetInt("HighScore");
        if (score > best)
        {
            best = score;
            PlayerPrefs.SetInt("HighScore", best);
        }

        BestPoints.text = best.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
