using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    public GameObject DayBg;
    public GameObject NightBg;

    public GameObject yellow;
    public GameObject Blue;
    public GameObject red;

    // Start is called before the first frame update
    void Start()
    {
        RedYellowBlue();
        dayorNightt();
    }

    void dayorNightt()
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

    }

    void RedYellowBlue()
    {
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

}
