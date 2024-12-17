using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ELocalFrameMode")]
	public enum ELocalFrameMode : int
	{
		FromObject = 0,
		FromGeometry = 1,
	}
}