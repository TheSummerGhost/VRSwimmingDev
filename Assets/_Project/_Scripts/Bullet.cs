using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float shootForce = 100f;
    
    Rigidbody rb;
    
    public float bulletDestroyTime = 10f;

    void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(transform.forward * shootForce);
    }

    // Update is called once per frame
    void Update()
    {
        bulletDestroyTime -= Time.deltaTime;
        if (bulletDestroyTime <= 0) {
            Destroy(gameObject);
        }
    }
}
