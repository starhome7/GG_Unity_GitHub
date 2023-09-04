using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Spawn : MonoBehaviour
{
    public GameObject cube_prefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        GameObject Cube_Object = Instantiate(cube_prefab, new Vector3(0f, 10f, 0f), rotation);


    }
}
