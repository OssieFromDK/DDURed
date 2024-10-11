using System.Collections;
using UnityEngine;

public class GirlSpawner : MonoBehaviour
{
    public GameObject GirlPrefab;
    public GameObject BlinkLightObject;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "GirlTriggerBox")
        {
            StartCoroutine(BlinkLight());
            Instantiate(GirlPrefab, new Vector3(157.22f, 0f, 125.95f), new Quaternion(0, -0.909961283f, 0, 0.414693326f));
        }
    }

    private IEnumerator BlinkLight()
    {
        BlinkLightObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        BlinkLightObject.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        BlinkLightObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        BlinkLightObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        BlinkLightObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        BlinkLightObject.SetActive(false);
    }
}
