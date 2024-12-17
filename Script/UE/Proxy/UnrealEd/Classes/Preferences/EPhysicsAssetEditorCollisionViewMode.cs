using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPhysicsAssetEditorCollisionViewMode")]
	public enum EPhysicsAssetEditorCollisionViewMode : byte
	{
		Solid = 0,
		Wireframe = 1,
		SolidWireframe = 2,
		None = 3,
	}
}