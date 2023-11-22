using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DitzelGames.FastIK
{
    public class Rotate : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(0, Time.deltaTime * 90, 0);
        }
    }
}

