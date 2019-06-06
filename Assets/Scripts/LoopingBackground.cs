using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour

{
    float speed;

    private void Start()
    {
        speed = DataContainer.singleton.data.backgroundSpeed;
    }

    private void Update()
    {
        gameObject.transform.Translate(-speed, 0, 0);
    }

    void OnBecameInvisible()
    {
        Debug.Log("hello");
        float YPos = gameObject.transform.position.y;
        float XPos = gameObject.transform.position.x;
        float newXPos = XPos * (-1);
        gameObject.transform.position = new Vector2(newXPos, YPos);
    }

    
}
