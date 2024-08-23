using UnityEngine;
using Random = System.Random;

[DefaultExecutionOrder(200)]
public class EnemyStats : MonoBehaviour
{
    public string enemyType;
    public string enemyClass;
    public int attack;
    public int health;
    public float speed;
    public float spawnRate;
    public GameObject prefab;
    private Random _rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        GameObject timeDay = GameObject.Find("Time_Day");
        SetTimeDay.Time timeOfDay = timeDay.GetComponent<SetTimeDay>().timeOfDay;

        switch (timeOfDay)
        {
            case SetTimeDay.Time.Morning:
            {
                if (enemyClass == "Archer")
                {
                    float randomValue = RandRange(0.2f, 0.4f);
                    spawnRate += randomValue;
                }
                if (enemyType == "Brown_Enemy")
                {
                    float randomValue = RandRange(-0.3f, -0.1f);
                    spawnRate += randomValue;
                }

                break;
            }
            case SetTimeDay.Time.Afternoon:
            {
                if (enemyClass == "Assassin")
                {
                    spawnRate = 0;
                }
                else if (enemyClass == "Grunt")
                {
                    attack += 1;
                }
                else
                {
                    float randomValue = RandRange(-0.2f, 0.2f);
                    spawnRate += randomValue;
                }

                break;
            }
            case SetTimeDay.Time.Night:
            {
                if (enemyClass == "Assassin")
                {   
                    float randomValue = RandRange(0.0f, 2.0f);
                    speed += randomValue;
                }

                break;
            }
        }
    }

    private float RandRange(float lowerBound, float upperBound)
    {
        return (float)_rand.NextDouble() * (upperBound - lowerBound) + lowerBound;
    }
}
