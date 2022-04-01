using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingObject : MonoBehaviour
{

    public int speed;
    public float orbitSpeed;
    public string orbitAroundTag;

    private GameObject _nearestStar;
    private Vector3 _prevPosOrbitedObj;
    private float _angle = 0;
    private bool moved = false;

    // Start is called before the first frame update
    void Start()
    {
        _nearestStar = Utils.FindNearestByTag(orbitAroundTag, gameObject);
        _prevPosOrbitedObj = _nearestStar.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*//!Find a way to start calculating where to go only after the orbited object has moved
        while(!_nearestStar.HasMoved()){
        }*/
        transform.Rotate(new Vector3(transform.rotation.x, speed * Time.deltaTime, transform.rotation.z));
        Vector3 deltaPosOrbitedObj = _nearestStar.transform.position - _prevPosOrbitedObj;
        //_angle = ((_angle + orbitSpeed) % 360) * Mathf.Deg2Rad;
        //Debug.Log(_angle);
        transform.position.Set(
            transform.position.x + deltaPosOrbitedObj.x,
            transform.position.y + deltaPosOrbitedObj.y,
            transform.position.z + deltaPosOrbitedObj.z);
        transform.RotateAround(_nearestStar.transform.position, Vector3.down, orbitSpeed * Time.deltaTime);
        /*gameObject.transform.position.Set(
            deltaPosOrbitedObj.x + Mathf.Sin(_angle) * orbitSpeed + gameObject.transform.position.x,
            deltaPosOrbitedObj.y + gameObject.transform.position.y,
            deltaPosOrbitedObj.z + Mathf.Cos(_angle) * orbitSpeed + gameObject.transform.position.z);*/
        _prevPosOrbitedObj =  _nearestStar.transform.position;
    }
}
