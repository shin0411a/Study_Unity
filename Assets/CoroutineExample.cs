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
        // 버튼에 클릭 이벤트 추가
        _startButton.onClick.AddListener(StartCoroutineOnClick);
    }

    void StartCoroutineOnClick()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        // 코루틴 시작 시간 기록
        float startTime = Time.time;

        Debug.Log("Coroutine started");
        yield return new WaitForSeconds(3f); // 3초 동안 멈춤


        Debug.Log("Coroutine resumed after 3 seconds");

        // 코루틴이 재개된 후의 경과 시간 계산
        float elapsedTime = Time.time - startTime;
        _startTimeText.text = $"Coroutine started at: {startTime.ToString("F2")} seconds\nElapsed Time: {elapsedTime.ToString("F2")} seconds";

        
    }
}
