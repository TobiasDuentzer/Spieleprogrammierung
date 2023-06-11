using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remover : MonoBehaviour
{
    public string parentName;

    void Start()
    {
        parentName = transform.name;
        StartCoroutine(RemoveClone());
    }

    IEnumerator RemoveClone()
    {
        yield return new WaitForSeconds(30);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
