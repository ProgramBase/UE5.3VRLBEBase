using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPropertyAccessObjectType")]
	public enum EPropertyAccessObjectType : byte
	{
		None = 0,
		Object = 1,
		WeakObject = 2,
		SoftObject = 3,
	}
}