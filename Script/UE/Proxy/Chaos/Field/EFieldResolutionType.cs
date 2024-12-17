using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldResolutionType")]
	public enum EFieldResolutionType : byte
	{
		Field_Resolution_Minimal = 0,
		Field_Resolution_DisabledParents = 1,
		Field_Resolution_Maximum = 2,
		Field_Resolution_Max = 3,
	}
}