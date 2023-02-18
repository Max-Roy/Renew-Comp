using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int cost;

    public int goldIncrease;

    public float timeBetweenIncrease;
    private float nextIncrese;


    private GameManager GM;

    private void Start()
    {
        GM = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(Time.time > nextIncrese)
        {
            nextIncrese = Time.time + timeBetweenIncrease;
            GM.gold += goldIncrease;
        }
    }
}
