using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EMeshEditingMaterialModes")]
	public enum EMeshEditingMaterialModes : int
	{
		ExistingMaterial = 0,
		Diffuse = 1,
		Grey = 2,
		Soft = 3,
		Transparent = 4,
		TangentNormal = 5,
		VertexColor = 6,
		CustomImage = 7,
		Custom = 8,
	}
}