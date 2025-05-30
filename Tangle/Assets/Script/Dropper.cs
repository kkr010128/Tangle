using UnityEngine;

// 플레이어의 과일 드롭을 제어하는 스크립트
// 입력 키를 감지하여 지정 위치에 과일을 떨어뜨림
public class Dropper : MonoBehaviour
{
    public FruitData[] fruitPrefabs;     // 드롭 가능한 과일 리스트
    public Transform dropPoint;          // 과일이 떨어지는 위치
    public KeyCode dropKey = KeyCode.Space; // 입력 키 (플레이어 A, B는 다르게 설정)

    void Update()
    {
        if (Input.GetKeyDown(dropKey))
        {
            int randomIndex = Random.Range(0, 2); // 초기에는 Cherry, Grape까지만
            GameObject fruit = Instantiate(fruitPrefabs[randomIndex].prefab, dropPoint.position, Quaternion.identity);
        }
    }
}