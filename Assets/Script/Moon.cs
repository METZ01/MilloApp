using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Moon : MonoBehaviour
{
    private struct OrbitAround{
        GameObject nearestPlanet;
        Vector3 prevPos;
    };

    public int speed;
    public float orbitSpeed;

    private GameObject _nearestStar;
    private OrbitAround planet;
    
    void Start(){
        _nearestStar = Utils.FindNearestByTag("Planet", gameObject);
        //planet.nearestPlanet = _nearestStar;

    }

    // Update is called once per frame
    void Update(){
        transform.Rotate(new Vector3(transform.rotation.x, speed * Time.deltaTime, transform.rotation.z));
        //transform.RotateAround(_nearestStar.transform.position, Vector3.down, orbitSpeed * Time.deltaTime);
        
    }
}
