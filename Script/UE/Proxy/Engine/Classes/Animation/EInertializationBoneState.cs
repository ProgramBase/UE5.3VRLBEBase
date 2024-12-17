using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EInertializationBoneState")]
	public enum EInertializationBoneState : long
	{
		Invalid = 0,
		Valid = 1,
		Excluded = 2,
	}
}