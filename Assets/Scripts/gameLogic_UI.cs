using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLogic_UI : MonoBehaviour
{
    private List<GameObject> spawnedObjects = new List<GameObject>();
    public void CreateObject(GameObject prefab)
    {
        //Instantiate(prefab, Camera.main.transform.position + 2 * Camera.main.transform.forward, Quaternion.identity);
        spawnedObjects.Add(Instantiate(prefab, Camera.main.transform.position + 2 * Camera.main.transform.forward, Quaternion.identity));
    }

}

