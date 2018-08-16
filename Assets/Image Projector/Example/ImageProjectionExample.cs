using UnityEngine;

public class ImageProjectionExample : MonoBehaviour {

    public GameObject prefab;
    public Texture testImage;

    private GameObject projector;

	void Start () {
        // 1) Create an instance of the image projector and set location and rotation of projector
        projector = Instantiate(prefab, new Vector3(-0.315f, 0.306f, 0.228f), Quaternion.Euler(2.711f, 161.066f, -0.918f));

        // 2) Setup the projector to replicate camera view
        projector.GetComponent<ImageProjector>().SetupProjector(55, testImage);
    }
}
