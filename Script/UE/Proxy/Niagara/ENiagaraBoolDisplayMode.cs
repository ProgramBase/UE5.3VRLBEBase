using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraBoolDisplayMode")]
	public enum ENiagaraBoolDisplayMode : byte
	{
		DisplayAlways = 0,
		DisplayIfTrue = 1,
		DisplayIfFalse = 2,
	}
}