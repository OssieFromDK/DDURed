using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(KillGame());
    }

    private IEnumerator KillGame()
    {
        yield return new WaitForSeconds(0.75f);
        Application.Quit();
    }
}
