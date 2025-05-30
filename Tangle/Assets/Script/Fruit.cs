using UnityEngine;

// 개별 과일 오브젝트에 붙는 스크립트
// 충돌 시 병합 조건 판단 및 병합 트리거 호출
public class Fruit : MonoBehaviour
{
    public FruitType type;               // 현재 과일의 타입
    private bool hasMerged = false;      // 중복 병합 방지용 플래그

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasMerged) return;

        Fruit other = collision.gameObject.GetComponent<Fruit>();
        if (other != null && other.type == this.type)
        {
            hasMerged = true;
            MergeManager.Instance.MergeFruits(this, other);
        }
    }
}