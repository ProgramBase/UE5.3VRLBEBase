using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ERevolvePropertiesCapFillMode")]
	public enum ERevolvePropertiesCapFillMode : byte
	{
		None = 0,
		CenterFan = 1,
		Delaunay = 2,
		EarClipping = 3,
	}
}