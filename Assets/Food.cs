using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;

    // called by unity when object is enabled for the first time
    private void Start() {
        RandomizePosition();
    }

    private void RandomizePosition() {
        Bounds bounds = this.gridArea.bounds;
        
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        
        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    // gets called when an 2D BoxCollider collides w/ this object    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            RandomizePosition();
        }
    }
}
