using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;

    // Update is called once per frame
    void Update()
    {
        elapsedResizeSeconds += Time.deltaTime;
        if(elapsedResizeSeconds >= TotalResizeSeconds)
        {
            scaleFactorSignMultiplier *= -1;
            elapsedResizeSeconds = 0;
        }

        float newVectorValue = Time.deltaTime * ScaleFactorPerSecond * scaleFactorSignMultiplier;
        transform.localScale += new Vector3(newVectorValue, newVectorValue, 1);
    }
}
