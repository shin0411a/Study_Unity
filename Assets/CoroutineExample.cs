using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineExample : MonoBehaviour
{
    [SerializeField] Button _startButton;
    [SerializeField] TextMeshProUGUI _startTimeText;

    private float _elapsedTime;

    void Start()
    {
        // ��ư�� Ŭ�� �̺�Ʈ �߰�
        _startButton.onClick.AddListener(StartCoroutineOnClick);
    }

    void StartCoroutineOnClick()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        // �ڷ�ƾ ���� �ð� ���
        float startTime = Time.time;

        Debug.Log("Coroutine started");
        yield return new WaitForSeconds(3f); // 3�� ���� ����


        Debug.Log("Coroutine resumed after 3 seconds");

        // �ڷ�ƾ�� �簳�� ���� ��� �ð� ���
        float elapsedTime = Time.time - startTime;
        _startTimeText.text = $"Coroutine started at: {startTime.ToString("F2")} seconds\nElapsed Time: {elapsedTime.ToString("F2")} seconds";

        
    }
}
