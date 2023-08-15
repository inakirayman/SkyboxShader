using UnityEngine;

[ExecuteInEditMode]
public class GetMainLightDirection : MonoBehaviour
{
    [SerializeField]
    private Material _skyboxMaterial;


    private void Update()
    {
        _skyboxMaterial.SetVector("_MainLightDirection", transform.forward);
    }
}
