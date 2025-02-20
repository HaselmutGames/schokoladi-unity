using UnityEngine;

public class Player : MonoBehaviour {

    private Vector2Int _gridPosition;


    private void Awake() {
        _gridPosition = new Vector2Int(8, 8);
    }

    private void Update() {
        transform.position = new Vector3(_gridPosition.x, _gridPosition.y);
    }
}
