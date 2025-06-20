using UnityEngine;
using System.Collections;

public class Skin : MonoBehaviour
{
    public GameObject basicSkin;

    private void OnEnable()
    {
        StartCoroutine(Check());
    }

    public IEnumerator Check()
    {
        basicSkin.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        basicSkin.SetActive(false);
    }

    private void OnDisable()
    {
        basicSkin.SetActive(true);
    }
}