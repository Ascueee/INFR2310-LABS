using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeGrab : MonoBehaviour
{
    public Transform ledgePos;
    public Transform otherPos;
    bool canLerp;
    public float desiredDuration;
    float elapsedTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canLerp)
        {

            elapsedTime += Time.deltaTime;

            float percentageComplete = elapsedTime / desiredDuration;
            otherPos.transform.position = Vector3.Lerp(otherPos.transform.position, ledgePos.position, percentageComplete);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("there has been a collision");
        canLerp = true;

    }
}
