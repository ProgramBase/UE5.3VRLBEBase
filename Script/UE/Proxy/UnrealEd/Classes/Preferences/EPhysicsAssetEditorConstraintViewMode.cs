using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPhysicsAssetEditorConstraintViewMode")]
	public enum EPhysicsAssetEditorConstraintViewMode : byte
	{
		None = 0,
		AllPositions = 1,
		AllLimits = 2,
	}
}