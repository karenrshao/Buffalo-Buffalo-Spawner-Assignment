using UnityEngine;

[DefaultExecutionOrder(300)]
public class SpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    private float _totalProbability;

    private System.Random _rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        // pick an enemy based on probability
        foreach (var enemy in enemies)
        {
            _totalProbability += enemy.GetComponent<EnemyStats>().spawnRate;
        }

        Spawn();
    }

    void Spawn()
    {
        float randomValue = (float) _rand.NextDouble() * _totalProbability;
        float currentProbability = 0.0f;
        foreach (var enemy in enemies)
        {
            currentProbability += enemy.GetComponent<EnemyStats>().spawnRate;
            if (currentProbability > randomValue)
            {
                GameObject instantiated = Instantiate(enemy.GetComponent<EnemyStats>().prefab, transform);
                instantiated.GetComponent<IndividualStats>().enemy = enemy;
                break;
            }
        }
    }
}
