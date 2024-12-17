using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EFlowDirectionPreference")]
	public enum EFlowDirectionPreference : byte
	{
		Inherit = 0,
		Culture = 1,
		LeftToRight = 2,
		RightToLeft = 3,
	}
}