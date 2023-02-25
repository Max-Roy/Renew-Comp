using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public Text goldDisplay;

    //private Building buildingToPlace;
    public GameObject grid;

    private void Start()
    {
        //cameraFollow.Setup(() => cameraFollowPosition, () => 80f);
    }

    private void Update()
    {
        goldDisplay.text = gold.ToString();
    }

    //public void BuyBuilding(Building building)
    //{
    //    if (gold >= building.cost)
    //    {
    //        gold -= building.cost;
    //        buildingToPlace = building;
    //        grid.SetActive(true);
    //    }
    //}
}
