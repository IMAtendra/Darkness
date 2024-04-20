using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpawaner : MonoBehaviour
{

    // Program for Spawn Random Objects and Random Position with Random Rotation
    [SerializeField] private GameObject _previewObj;
    public GameObject[] prefab;

    void GetLoadObject()
    {
        var limitOfPosition = 4f;
        float angle = 10f * Mathf.PI * 2 / prefab.Length;
        var limitOfRotation = -angle * Mathf.Rad2Deg;

        var index = Random.Range(0, prefab.Length);
        var pos = new Vector3(Random.Range(-limitOfPosition, limitOfPosition),
                              0,
                              Random.Range(-limitOfPosition, limitOfPosition));
        var rot = Quaternion.Euler(0,
                                   Random.Range(-limitOfRotation, limitOfRotation),
                                   0);
        
        if (_previewObj != null) 
        {
            Destroy(_previewObj, 2f);
            Debug.Log(prefab[index].name + " is Eliminate");
        }

        _previewObj = Instantiate(prefab[index],
                                  pos,
                                  rot);


    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) InvokeRepeating("GetLoadObject", 0f, 3f);
    }
}
