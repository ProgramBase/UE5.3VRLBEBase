using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EInputActionValueType")]
	public enum EInputActionValueType : byte
	{
		Boolean = 0,
		Axis1D = 1,
		Axis2D = 2,
		Axis3D = 3,
	}
}