using UnityEngine;

public class ImageProjector : MonoBehaviour {

    Projector projector;
    Material baseMat;
    Texture image;

	// Use this for initialization
	void Awake () {
        projector = GetComponent<Projector>();
        baseMat = projector.material;
	}

    public void SetupProjector(float fov, Texture image)
    {
        projector.fieldOfView = fov;

        this.image = image;
        image.wrapMode = TextureWrapMode.Clamp;

        projector.material = new Material(baseMat);
        projector.material.SetTexture("_ShadowTex", image);
    }
}
