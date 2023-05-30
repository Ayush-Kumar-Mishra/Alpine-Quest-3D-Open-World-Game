using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionScript : MonoBehaviour
{

    public GameObject instructionImage;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            instructionImage.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
