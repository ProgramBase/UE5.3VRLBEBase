using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECollisionResponse")]
	public enum ECollisionResponse : byte
	{
		ECR_Ignore = 0,
		ECR_Overlap = 1,
		ECR_Block = 2,
	}
}