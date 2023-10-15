using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillerSapwner : MonoBehaviour
{
    public GameObject Walls;
    float timer = 0;

    public GameObject DayBg;
    public GameObject NightBg;

    public GameObject yellow;
    public GameObject Blue;
    public GameObject red;

    // Start is called before the first frame update
    void Start()
    {
        int dayOrNight = Random.Range(1, 3);

        if (dayOrNight == 1)
        {
            DayBg.SetActive(true);
        }

        else if (dayOrNight == 2)
        {
            NightBg.SetActive(true);
        }

        int RedBlueOrYellow = Random.Range(1, 4);

        if (RedBlueOrYellow == 1)
        {
            yellow.SetActive(true);
        }

        else if (RedBlueOrYellow == 2)
        {
            Blue.SetActive(true);
        }

        else if (RedBlueOrYellow == 3)
        {
            red.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 1)
        {
            int ykas = Random.Range(-2, 2) ;

            transform.position += new Vector3(0, ykas, 0);

            Spawn();
            timer = 0;
            transform.position = new Vector3(9, 0, 0);
        }      
    }

    void Spawn()
    {
        Instantiate(Walls, transform.position, transform.rotation);
    
    }
}
