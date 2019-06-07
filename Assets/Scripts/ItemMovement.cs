using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{

    float itemSpeed;

    void Start()
    {
        itemSpeed = DataContainer.singleton.data.itemSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(-itemSpeed * Time.deltaTime, 0, 0);
    }
}
