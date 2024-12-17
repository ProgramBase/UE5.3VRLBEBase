using Script.CoreUObject;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.EDataStreamSendStatus")]
	public enum EDataStreamSendStatus : byte
	{
		Send = 0,
		Pause = 1,
	}
}