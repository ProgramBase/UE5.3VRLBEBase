using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialStencilCompare")]
	public enum EMaterialStencilCompare : byte
	{
		MSC_Less = 0,
		MSC_LessEqual = 1,
		MSC_Greater = 2,
		MSC_GreaterEqual = 3,
		MSC_Equal = 4,
		MSC_NotEqual = 5,
		MSC_Never = 6,
		MSC_Always = 7,
		MSC_Count = 8,
	}
}