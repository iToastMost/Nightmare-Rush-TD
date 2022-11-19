using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHealthPoints = 5;
    [SerializeField] int currentHealthPoints = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentHealthPoints = maxHealthPoints;   
    }

    // Update is called once per frame
    void OnParticleCollision(GameObject collison)
    {
        ProcessHit();
    }
    void ProcessHit()
    {
        currentHealthPoints--;

        if(currentHealthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
