using UnityEngine;

// 게임 전체 상태를 관리하는 스크립트
// 점수 처리 및 병합 이벤트 핸들링
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerScoreManager playerAScore;
    public PlayerScoreManager playerBScore;

    void Awake()
    {
        Instance = this; // 싱글톤 초기화
    }

    // 병합 이벤트 발생 시 호출됨
    public void OnFruitMerged(FruitType newType)
    {
        int score = (int)newType * 10;

        // 임시로 PlayerA만 점수 증가 (이후 병합 주체 판단 분기 필요)
        playerAScore.AddScore(score);
    }
}