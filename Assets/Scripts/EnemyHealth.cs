using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHealthPoints = 5;
    [Tooltip("Adds amount to maxHP when enemy dies")]
    [SerializeField] int difficultyRamp = 1;

    int currentHealthPoints = 0;

    Enemy enemy;
    // Start is called before the first frame update
    void OnEnable()
    {
        currentHealthPoints = maxHealthPoints;   
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();
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
            gameObject.SetActive(false);
            maxHealthPoints += difficultyRamp;
            enemy.RewardGold();
        }
    }
}
