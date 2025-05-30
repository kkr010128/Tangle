using UnityEngine;
using TMPro;

// 플레이어 점수를 관리하고 UI에 반영하는 스크립트
public class PlayerScoreManager : MonoBehaviour
{
    public TMP_Text scoreText; // UI 텍스트 (Canvas 내 텍스트 연결 필요)
    private int score = 0;

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = score.ToString(); // UI 반영
    }
}