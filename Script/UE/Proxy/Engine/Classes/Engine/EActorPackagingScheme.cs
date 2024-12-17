using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EActorPackagingScheme")]
	public enum EActorPackagingScheme : byte
	{
		Original = 0,
		Reduced = 1,
	}
}