using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.ETextureType")]
	public enum ETextureType : int
	{
		ThicknessAndSurfaceAttributes = 0,
		SpatialGradients = 1,
		Normals = 2,
	}
}