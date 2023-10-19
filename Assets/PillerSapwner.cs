using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillerSapwner : MonoBehaviour
{
    public GameObject Walls;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
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
