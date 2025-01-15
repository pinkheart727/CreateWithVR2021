using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [Header("Spawning")]
    public GameObject projectile;
    public GameObject spawnPoint;

    public void Shoot()
    {
        Instantiate(projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
