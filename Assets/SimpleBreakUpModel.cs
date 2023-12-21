using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBreakUpModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Debug.Log(RandomGaussian(5.0, 1.0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    double RandomGaussian(double mean, double stdDev)
    {
        double u1 = 1.0 - Random.Range(0, 1.0f);
        double u2 = 1.0 - Random.Range(0, 1.0f);
        double randStdNormal = Mathf.Sqrt((float)(-2.0 * Mathf.Log((float)u1))) * Mathf.Sin((float)(2.0 * Mathf.PI * u2));
        double randNormal = mean + stdDev * randStdNormal;
        return randNormal;
    }
}
