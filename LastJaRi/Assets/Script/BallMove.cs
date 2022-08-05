using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private float _speedX = -8f;
    private float _speedZ = -8f;
    private Vector3 _ballVector;
    private Rigidbody _rigidbody;
    void Start()
    {
        StartCoroutine(Move());
    }
    void Update()
    {
        
        _ballVector = new Vector3(_speedX * Time.deltaTime, 0, _speedZ * Time.deltaTime);
        transform.Translate(_ballVector);
        
    }

    IEnumerator Move()
    {
        while(true)
        {
            _speedX *= -1;
            _speedZ *= -1;
            yield return new WaitForSeconds(2.0f);

        }
    }
}
