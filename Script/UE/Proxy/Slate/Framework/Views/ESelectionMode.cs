using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.ESelectionMode")]
	public enum ESelectionMode : byte
	{
		None = 0,
		Single = 1,
		SingleToggle = 2,
		Multi = 3,
	}
}