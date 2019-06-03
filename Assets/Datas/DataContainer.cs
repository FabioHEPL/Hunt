using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataContainer : MonoBehaviour
{
    public static DataContainer singleton;
    public Data Data;
    public DataThomas DataThomas;
    public DataFabio DataFabio;
    public DataLudo DataLudo;
    void Awake()
    {
        if (singleton != null)
            Destroy(gameObject);
        else
            singleton = this;
    }

}
