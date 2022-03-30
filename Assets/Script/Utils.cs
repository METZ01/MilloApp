using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Utils
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static GameObject FindNearestByTag(string tag, GameObject self){
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        GameObject found = null;
        float distance; 
        float minDistance = Vector3.Distance(self.transform.position, taggedObjects[0].transform.position);
        foreach(GameObject _current in taggedObjects){
            distance = Vector3.Distance(self.transform.position, _current.transform.position);
            if(distance <= minDistance){
                found = _current;
                minDistance = distance;
            }
        }
        return found;
    }
}
