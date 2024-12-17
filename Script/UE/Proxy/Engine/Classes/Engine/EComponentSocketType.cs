using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EComponentSocketType")]
	public enum EComponentSocketType : long
	{
		Invalid = 0,
		Bone = 1,
		Socket = 2,
	}
}