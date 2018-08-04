using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

    public string SzenenName;
        
    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(SzenenName);
    }

}
