using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public bool enemyNewOn = false;

    // объект, который будет создан
    public GameObject enemyNew;

    // место, в котором будут создан объект
    public Transform enemyPoint;


    private void Update()
    {
        if (enemyNewOn)
        {
            // создание нового скелета
            Instantiate(enemyNew, enemyPoint.transform.position, Quaternion.identity);
            enemyNewOn = false;
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        enemyNewOn = true;
    }


    private void OnTriggerExit(Collider other)
    {
        this.gameObject.SetActive(false); // выключение триггера
    }

}
