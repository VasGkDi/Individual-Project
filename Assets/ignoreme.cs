using UnityEngine;

public class IgnorePlayerColliderForUI : MonoBehaviour
{
    private void Start()
    {
        // Ignore raycasts for the player's layer.
        int playerLayer = LayerMask.NameToLayer("PlayerBody");
        Physics.IgnoreLayerCollision(playerLayer, LayerMask.NameToLayer("UI"), true);
    }
}