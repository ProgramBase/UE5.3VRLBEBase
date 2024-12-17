using Script.CoreUObject;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.ERetargetTranslationMode")]
	public enum ERetargetTranslationMode : byte
	{
		None = 0,
		GloballyScaled = 1,
		Absolute = 2,
	}
}