using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimPhysCollisionType")]
	public enum AnimPhysCollisionType : byte
	{
		CoM = 0,
		CustomSphere = 1,
		InnerSphere = 2,
		OuterSphere = 3,
	}
}