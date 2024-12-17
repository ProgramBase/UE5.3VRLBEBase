using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPhysicsAssetEditorMeshViewMode")]
	public enum EPhysicsAssetEditorMeshViewMode : byte
	{
		Solid = 0,
		Wireframe = 1,
		None = 2,
	}
}