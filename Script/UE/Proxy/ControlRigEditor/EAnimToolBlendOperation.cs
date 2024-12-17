using Script.CoreUObject;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.EAnimToolBlendOperation")]
	public enum EAnimToolBlendOperation : byte
	{
		Tween = 0,
		BlendToNeighbor = 1,
		PushPull = 2,
	}
}