using Script.CoreUObject;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.ETimecodeBoneMode")]
	public enum ETimecodeBoneMode : byte
	{
		All = 0,
		Root = 1,
		UserDefined = 2,
	}
}