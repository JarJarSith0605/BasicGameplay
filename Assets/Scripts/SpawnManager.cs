using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
         SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnpos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}


