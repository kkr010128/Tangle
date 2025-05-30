using UnityEngine;

// 병합 처리 로직을 담당하는 싱글톤 스크립트
// 같은 레벨의 과일 2개가 충돌하면 더 높은 레벨의 과일 생성
public class MergeManager : MonoBehaviour
{
    public static MergeManager Instance;

    public FruitData[] fruitPrefabs; // 과일 프리팹 리스트 (Inspector에서 등록)

    void Awake()
    {
        Instance = this; // 싱글톤 초기화
    }

    public void MergeFruits(Fruit a, Fruit b)
    {
        Vector3 spawnPos = (a.transform.position + b.transform.position) / 2;
        FruitType newType = (FruitType)((int)a.type + 1);

        if ((int)newType > (int)FruitType.Watermelon)
        {
            // 수박 이상은 더 이상 병합하지 않고 소멸
            Destroy(a.gameObject);
            Destroy(b.gameObject);
            return;
        }

        // 다음 레벨의 과일 생성
        GameObject newFruitPrefab = GetFruitPrefab(newType);
        Instantiate(newFruitPrefab, spawnPos, Quaternion.identity);

        // 기존 과일 제거
        Destroy(a.gameObject);
        Destroy(b.gameObject);

        // 게임 매니저에 병합 이벤트 통보
        GameManager.Instance.OnFruitMerged(newType);
    }

    // 과일 타입에 맞는 프리팹 반환
    GameObject GetFruitPrefab(FruitType type)
    {
        foreach (var data in fruitPrefabs)
        {
            if (data.type == type)
                return data.prefab;
        }
        return null;
    }
}