using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public int speed;
    public float orbitSpeed;

    private GameObject _nearestStar;


    
    void Start(){
        _nearestStar = Utils.FindNearestByTag("Planet", gameObject);
    }

    // Update is called once per frame
    void Update(){
        transform.Rotate(new Vector3(transform.rotation.x, speed * Time.deltaTime, transform.rotation.z));
        transform.RotateAround(_nearestStar.transform.position, Vector3.down, orbitSpeed * Time.deltaTime);
    }
}
