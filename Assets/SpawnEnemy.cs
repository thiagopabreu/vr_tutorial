using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject cube;
    public int i;
    void Start()
    {
        StartCoroutine(SpawnEnemys());
    }

    private IEnumerator SpawnEnemys()
    {
        var enemyToSpawn = Random.Range(5, 10);

        for(int i = 0; i < enemyToSpawn; i++)
        {
            var x = Random.Range(-20, 20);
            var z = Random.Range(-20, 20);

            var enemy = Instantiate(cube, new Vector3(x, 10f, z), Quaternion.identity);
        }

        yield return new WaitForSeconds(0.3f);
        yield return SpawnEnemys();

    }
}
