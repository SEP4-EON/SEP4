using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject toBeSpawned;
	public float waitTime = 1f;
	public GameObject spawnLocation;
	private int spawnCount = 0;
	public int maxSpawn;

    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(SpawnBoi());
	}

    // Update is called once per frame
    void Update()
    {
		

	}

	IEnumerator SpawnBoi()
	{
		while (spawnCount < maxSpawn)
		{
			Instantiate(toBeSpawned, spawnLocation.transform.position, spawnLocation.transform.rotation);

			
			spawnCount += 1;

			print(spawnCount);

			yield return new WaitForSeconds(waitTime);

		}

	}
}
