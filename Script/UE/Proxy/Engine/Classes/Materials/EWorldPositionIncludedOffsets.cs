using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWorldPositionIncludedOffsets")]
	public enum EWorldPositionIncludedOffsets : byte
	{
		WPT_Default = 0,
		WPT_ExcludeAllShaderOffsets = 1,
		WPT_CameraRelative = 2,
		WPT_CameraRelativeNoOffsets = 3,
	}
}