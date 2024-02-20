using System.Collections;
using UnityEngine;

public class CoroutineExample2 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        Debug.Log("Coroutine started");

        MyOtherCoroutine();

        yield return new WaitForSeconds(3f);

        Debug.Log("Coroutine resumed after 3 seconds");
    }

    IEnumerator MyOtherCoroutine()
    {
        Debug.Log("Other Coroutine started");
        yield return new WaitForSeconds(2f);
        Debug.Log("Other Coroutine resumed after 2 seconds");
    }
}
