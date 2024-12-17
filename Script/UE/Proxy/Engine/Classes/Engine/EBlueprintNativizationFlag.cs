using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBlueprintNativizationFlag")]
	public enum EBlueprintNativizationFlag : byte
	{
		Disabled = 0,
		Dependency = 1,
		ExplicitlyEnabled = 2,
	}
}