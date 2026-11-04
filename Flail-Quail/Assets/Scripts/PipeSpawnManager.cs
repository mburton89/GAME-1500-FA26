using UnityEngine;

public class PipeSpawnManager : MonoBehaviour
{
    float secondsPassed;
    public float maxSecondsPassed;
    public GameObject pipesPrefab;
    public float maxRandY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondsPassed += Time.deltaTime;

        if (secondsPassed >= maxSecondsPassed)
        {
            SpawnPipe();
            secondsPassed = 0;
        }
    }

    void SpawnPipe()
    {
        GameObject newPipe = Instantiate(pipesPrefab);
        float randY = Random.Range(-maxRandY, maxRandY);
        newPipe.transform.position = transform.position + new Vector3(0, randY, 0);
        Destroy(newPipe, 10);
    }


}
