using UnityEngine;

// ←: 왼쪽, →: 오른쪽, ↓: 과일 드롭
public class PlayerArrowMoveAndDrop : MonoBehaviour
{
    public float moveSpeed = 5f;                     // 좌우 이동 속도
    public Transform dropPoint;                      // 과일 드롭 위치
    public FruitData[] fruitPrefabs;                 // 드롭 가능한 과일 프리팹 목록

    void Update()
    {
        // 이동
        float move = 0f;
        if (Input.GetKey(KeyCode.LeftArrow)) move = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) move = 1f;

        transform.position += new Vector3(move, 0, 0) * moveSpeed * Time.deltaTime;

        // 과일 드롭
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DropFruit();
        }
    }

    void DropFruit()
    {
        int randomIndex = Random.Range(0, 2); // 초기 과일 2종만
        Instantiate(fruitPrefabs[randomIndex].prefab, dropPoint.position, Quaternion.identity);
    }
}