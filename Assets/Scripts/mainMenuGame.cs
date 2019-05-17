using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuGame : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime*3, Space.World);
    }
}
