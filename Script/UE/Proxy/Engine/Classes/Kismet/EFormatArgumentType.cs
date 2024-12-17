using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFormatArgumentType")]
	public enum EFormatArgumentType : byte
	{
		Int = 0,
		UInt = 1,
		Float = 2,
		Double = 3,
		Text = 4,
		Gender = 5,
	}
}