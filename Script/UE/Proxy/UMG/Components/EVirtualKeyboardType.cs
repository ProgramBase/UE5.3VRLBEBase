using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EVirtualKeyboardType")]
	public enum EVirtualKeyboardType : byte
	{
		Default = 0,
		Number = 1,
		Web = 2,
		Email = 3,
		Password = 4,
		AlphaNumeric = 5,
	}
}