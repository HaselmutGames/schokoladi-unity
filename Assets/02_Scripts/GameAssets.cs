using UnityEngine;

public class GameAssets : MonoBehaviour {
    public static GameAssets instance;
    public Sprite playerSprite;

    private void Awake() {
        instance = this;
    }
}
