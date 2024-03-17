using UnityEngine;

public class CenterBlock : MonoBehaviour
{
    public Transform Point1;
    public Transform Point2;

    private void Update()
    {
        transform.position = Vector3.Lerp(Point1.position, Point2.position, 0.5f);
    }
}
