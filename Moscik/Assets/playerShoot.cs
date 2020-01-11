using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour {
    [SerializeField] private ballControll ballPrefab;

    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Shoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Shoot() {
       var ballInstance = Instantiate(ballPrefab);
       ballInstance.transform.position = spawnPoint.position;
       ballInstance.AddForce(spawnPoint.forward, 20f);
    }
}
