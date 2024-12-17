using Script.CoreUObject;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.EProjectPackagingBuild")]
	public enum EProjectPackagingBuild : int
	{
		Always = 0,
		Never = 1,
		IfProjectHasCode = 2,
		IfEditorWasBuiltLocally = 3,
	}
}