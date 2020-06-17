using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float rotationSpeed;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f,rotationSpeed * Time.deltaTime, 0f));
    }
    private void OnTriggerEnter(Collider other)
    {
        
        this.gameObject.SetActive(false);
        GameManager gamemanager = FindObjectOfType<GameManager>();
        gamemanager.Addcoin();
        
    }
    
}
