using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshFacesColorMode")]
	public enum EMeshFacesColorMode : int
	{
		None = 0,
		ByGroup = 1,
		ByMaterialID = 2,
		ByUVIsland = 3,
	}
}