using System.Linq;
using UnityEngine;

[DefaultExecutionOrder(100)]
public class SetTimeDay : MonoBehaviour
{
    public enum Time
    {
        Morning,
        Afternoon,
        Night
    }

    public Time timeOfDay;
    // Start is called before the first frame update
    void Start()
    {
        var values = System.Enum.GetValues(typeof(Time));
        System.Random rand = new System.Random();
        int randomIndex = rand.Next(values.Length);
        timeOfDay = (Time) values.GetValue(randomIndex);
    }
}
