using Script.CoreUObject;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.EContextTargetFlags")]
	public enum EContextTargetFlags : long
	{
		TARGET_Blueprint = 1,
		TARGET_SubComponents = 2,
		TARGET_NodeTarget = 4,
		TARGET_PinObject = 8,
		TARGET_SiblingPinObjects = 16,
		TARGET_BlueprintLibraries = 32,
		TARGET_NonImportedTypes = 64,
		ContextTargetFlagsEnd = 65,
	}
}