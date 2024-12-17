using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EAutoSaveMethod")]
	public enum EAutoSaveMethod : byte
	{
		BackupAndRestore = 0,
		BackupAndOverwrite = 1,
	}
}