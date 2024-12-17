using Script.CoreUObject;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.ECreateModelingObjectResult")]
	public enum ECreateModelingObjectResult : byte
	{
		Ok = 0,
		Cancelled = 1,
		Failed_Unknown = 2,
		Failed_NoAPIFound = 3,
		Failed_InvalidWorld = 4,
		Failed_InvalidMesh = 5,
		Failed_InvalidTexture = 6,
		Failed_AssetCreationFailed = 7,
		Failed_ActorCreationFailed = 8,
		Failed_InvalidMaterial = 9,
	}
}