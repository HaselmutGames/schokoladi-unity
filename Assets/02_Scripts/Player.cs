using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private GameInput _gameInput;
    private void Update() {
        Vector2 inputVector = _gameInput.GetMovementVectorNormalized();
        Vector3 moveDirection = new Vector3(inputVector.x, inputVector.y);
        transform.position += moveDirection * _moveSpeed * Time.deltaTime;
    }
}
