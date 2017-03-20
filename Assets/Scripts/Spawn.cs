using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject redBall;
    public GameObject reddBall;
    public GameObject redddBall;
    public GameObject reddddBall;
    public float spawnTime = 5;
    public List<int> xCords = new List<int>();
    public List<int> yCords = new List<int>();
    void Start()
    {
        List<Transform> spawnLocs = new List<Transform>();
        xCords.Add(-2);
        xCords.Add(2);
        yCords.Add(5);
        yCords.Add(-4);
      
       
        InvokeRepeating("spawn", spawnTime, spawnTime);
        Debug.Log("start");
    }

    
    void Update()
    {
        
    }
    void spawn()
    {
     
        int randomNum = Random.Range(0, 4);
        if (randomNum == 0)
        {
            Instantiate(redBall, new Vector3(16.2f, 617.2f, 0), redBall.transform.rotation);
        }
        if (randomNum == 1)
        {
            Instantiate(reddBall, new Vector3(17f, 21f, 0), reddBall.transform.rotation);
        }
        if (randomNum == 2)
        {
            Instantiate(redddBall, new Vector3(379f, 20, 0), redddBall.transform.rotation);
        }
        if (randomNum == 3)
        {
            Instantiate(reddddBall, new Vector3(379f,619f, 0), reddddBall.transform.rotation);
        }
        
        Debug.Log("randomNum:" + randomNum);
        Debug.Log("spawn");
    }
}