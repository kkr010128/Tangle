using UnityEngine;

// 과일의 타입과 프리팹을 연결하기 위한 데이터 클래스
[System.Serializable]
public class FruitData
{
    public FruitType type;           // 과일 종류 (레벨)
    public GameObject prefab;        // 해당 과일의 프리팹
}