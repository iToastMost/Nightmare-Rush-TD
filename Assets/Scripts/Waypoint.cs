using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    
    [SerializeField] bool isPlaceabe;
    public bool IsPlaceable { get { return isPlaceabe; } }
    private void OnMouseDown()
    {
        if (isPlaceabe)
        {
            bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlaceabe = !isPlaced;
        }
    }
}
