using UnityEngine;

public class PositionSender : MonoBehaviour
{
    public Transform[] trackedObjects;

    private Vector2[] positions;

    private void Awake()
    {
        this.CreatePositionsArray();
    }

    private void Update()
    {
        if (this.positions.Length != this.trackedObjects.Length)
            this.CreatePositionsArray();

        for (int i = 0; i < this.trackedObjects.Length; i++)
            this.positions[i].Set(this.trackedObjects[i].position.z, this.trackedObjects[i].position.x);

        this.Send();
    }

    private void CreatePositionsArray()
    {
        this.positions = new Vector2[this.trackedObjects.Length];
    }

    private void Send()
    {
        throw new System.NotImplementedException();
    }
}
