using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EInertializationSpace")]
	public enum EInertializationSpace : long
	{
		Default = 0,
		WorldSpace = 1,
		WorldRotation = 2,
	}
}