using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETransitionRequestOverwriteMode")]
	public enum ETransitionRequestOverwriteMode : byte
	{
		Append = 0,
		Ignore = 1,
		Overwrite = 2,
	}
}