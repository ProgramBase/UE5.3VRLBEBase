using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EViewTargetBlendFunction")]
	public enum EViewTargetBlendFunction : byte
	{
		VTBlend_Linear = 0,
		VTBlend_Cubic = 1,
		VTBlend_EaseIn = 2,
		VTBlend_EaseOut = 3,
		VTBlend_EaseInOut = 4,
		VTBlend_PreBlended = 5,
	}
}