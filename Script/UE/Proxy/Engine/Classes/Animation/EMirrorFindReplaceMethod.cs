using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMirrorFindReplaceMethod")]
	public enum EMirrorFindReplaceMethod : byte
	{
		Prefix = 0,
		Suffix = 1,
		RegularExpression = 2,
	}
}