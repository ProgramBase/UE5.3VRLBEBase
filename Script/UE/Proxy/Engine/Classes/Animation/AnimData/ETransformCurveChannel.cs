using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETransformCurveChannel")]
	public enum ETransformCurveChannel : byte
	{
		Position = 0,
		Rotation = 1,
		Scale = 2,
		Invalid = 3,
	}
}