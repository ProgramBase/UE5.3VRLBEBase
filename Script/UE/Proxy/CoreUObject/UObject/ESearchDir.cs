using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ESearchDir")]
	public enum ESearchDir : byte
	{
		FromStart = 0,
		FromEnd = 1,
	}
}