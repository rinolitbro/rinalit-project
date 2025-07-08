using UnityEngine;
public class SkyBoxController : MonoBehaviour
{
    public Material skyboxMaterial;
    public float rotationSpeed = 1f;
    void Start()
    {
        RenderSettings.skybox = skyboxMaterial;
    }
    void Update()
    {
        // Rotate the skybox material over time  
        float rotation = Time.time * rotationSpeed;
        skyboxMaterial.SetFloat("_Rotation", rotation);
    }
}
