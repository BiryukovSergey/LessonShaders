using UnityEngine;

public class Test : MonoBehaviour
{
    public Material material;

    void Start()
    {
        material.SetColor("_Color", Color.white); // устанавливает новый цвет в материал
        float height = material.GetFloat("_MixValue"); // считывает значение параметра смешивания из материала
    }
}