using Script.CoreUObject;

namespace Script.Localization
{
	[PathName("/Script/Localization.EPortableObjectFormat")]
	public enum EPortableObjectFormat : byte
	{
		Unreal = 0,
		Crowdin = 1,
	}
}