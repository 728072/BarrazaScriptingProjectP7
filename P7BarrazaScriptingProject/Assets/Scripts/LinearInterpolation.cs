using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    // float result = Mathf.Lerp (3f, 5f, 0.5f); - result = 4 because 4 is between 3 and 5.
    void Start()
    {
        //Vector3 from = new Vector3(1f, 2f, 3f);
        // Vector3 to = new Vector3(5f, 6f, 7f);

        // Vector3 result = Vector3.Lerp(from, to, 0.75f);

        //the result is (4, 5, 6) because 4 is 75% of the way between 1 and 5; 5 is 75% of the way between 2 and 6 and 6 is 75% of the way between 3 and 7.
    }

    // Update is called once per frame
    void Update()
    {
        // light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);

        //light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);

        // the first script the intensity of the light starts off at 0 then after the first update it will be set to 4. The next frame it will be set to 6, then to 7, then to 7.5 and so on, the second script intensity would happen per second instead of per frame..
    }
}
