using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EUVProjectionToolInitializationMode")]
	public enum EUVProjectionToolInitializationMode : int
	{
		Default = 0,
		UsePrevious = 1,
		AutoFit = 2,
		AutoFitAlign = 3,
	}
}