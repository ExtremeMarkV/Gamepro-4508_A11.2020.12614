using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float movespeed;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.x > transform.position.x){
            transform.position = new Vector3(transform.position.x + movespeed * Time.deltaTime, 
            transform.position.y,
            transform.position.z);
        }
    }
}
