using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingItem : Explodable
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Explode();
        }
    }
}