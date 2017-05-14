using UnityEngine;

public class Spawner : MonoBehaviour {

	public float spawnDelay = .3f;
	float nextTimeToSpawn = 0f;

	public GameObject car;

	public Transform[] spawnPoints;

	private void Update()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];
		Instantiate(car,spawnPoint.position,spawnPoint.rotation);
	}
}
