using UnityEngine;

public class TankFollower : MonoBehaviour {
    [SerializeField] private GameObject tank;
    private Vector3 offset = new Vector3(0, 5, -7);

    private void LateUpdate() {
        transform.position = tank.transform.position + offset;
    }
}