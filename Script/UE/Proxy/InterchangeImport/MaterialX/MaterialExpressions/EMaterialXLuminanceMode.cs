using Script.CoreUObject;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.EMaterialXLuminanceMode")]
	public enum EMaterialXLuminanceMode : byte
	{
		ACEScg = 0,
		Rec709 = 1,
		Rec2020 = 2,
		Rec2100 = 2,
		Custom = 3,
	}
}