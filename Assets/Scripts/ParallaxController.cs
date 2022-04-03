using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    private MeshRenderer meshRederer;
    public float animationSpeed = 1f;

    private void Awake()
    {
        meshRederer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRederer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
