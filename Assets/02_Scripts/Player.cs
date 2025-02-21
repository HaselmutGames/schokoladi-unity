using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private GameInput _gameInput;
    [SerializeField] private Transform _playerVisual;
    private void Update() {
        Vector2 inputVector = _gameInput.GetMovementVectorNormalized();
        Vector3 moveDirection = new Vector3(inputVector.x, inputVector.y);
        transform.position += moveDirection * _moveSpeed * Time.deltaTime;

        if (moveDirection != Vector3.zero) {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;

            Quaternion targetRotaion = Quaternion.Euler(0, 0, angle);
            float rotationSpeed = 10f;
            _playerVisual.rotation = Quaternion.Slerp(_playerVisual.rotation, targetRotaion, rotationSpeed * Time.deltaTime);

            if (moveDirection.x < 0) {
                _playerVisual.localScale = new Vector3(1, -1, 1);
            }
            else {
                _playerVisual.localScale = new Vector3(1, 1, 1);
            }
        }

    }
}
