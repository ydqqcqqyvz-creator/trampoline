using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float JumpFactor = 10;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = JumpFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
