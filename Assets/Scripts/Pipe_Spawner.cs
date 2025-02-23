using UnityEngine;

public class Pipe_Spawner : MonoBehaviour
{
    public GameObject pipe;

    float topLayer = 3.74f;
    float bottomLayer = -3.31f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPipe", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnPipe()
    {
        float randomPoint = Random.Range(bottomLayer, topLayer);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomPoint);
        Instantiate(pipe, spawnPosition, transform.rotation);
    }
}
