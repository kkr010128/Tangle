using UnityEngine;

// 각 플레이어의 필드를 관리하는 스크립트
// 다른 플레이어 오브젝트가 들어오면 제거하거나 제한 처리 가능
public class PlayerField : MonoBehaviour
{
    public string playerTag; // 이 필드를 사용하는 플레이어의 태그 (예: "PlayerA")

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(playerTag))
        {
            // 잘못된 오브젝트가 들어왔을 경우 제거
            Destroy(other.gameObject);
        }
    }
}