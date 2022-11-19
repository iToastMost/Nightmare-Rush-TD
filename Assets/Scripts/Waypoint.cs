using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    
    [SerializeField] bool isPlaceabe;
    public bool IsPlaceable { get { return isPlaceabe; } }
    private void OnMouseDown()
    {
        if (isPlaceabe)
        {
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlaceabe = false;
        }
    }
}
