using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigControlType")]
	public enum ERigControlType : byte
	{
		Bool = 0,
		Float = 1,
		Integer = 2,
		Vector2D = 3,
		Position = 4,
		Scale = 5,
		Rotator = 6,
		Transform = 7,
		TransformNoScale = 8,
		EulerTransform = 9,
	}
}