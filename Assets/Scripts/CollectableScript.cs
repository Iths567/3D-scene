using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    float maxDistance = 10;

    void Update()
    {
        RaycastHit collectable = new RaycastHit();

        if(Physics.Raycast(transform.position, transform.forward, out collectable, maxDistance))
        {
            if(collectable.transform.tag == "collTag")
            {
                Debug.Log("Looking at Collectable");
            }
        }

    }
}
