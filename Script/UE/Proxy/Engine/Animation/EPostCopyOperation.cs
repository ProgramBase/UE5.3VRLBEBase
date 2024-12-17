using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPostCopyOperation")]
	public enum EPostCopyOperation : byte
	{
		None = 0,
		LogicalNegateBool = 1,
	}
}