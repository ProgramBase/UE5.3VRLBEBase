using Script.CoreUObject;

namespace Script.AndroidFileServer
{
	[PathName("/Script/AndroidFileServer.EAFSActiveType")]
	public enum EAFSActiveType : byte
	{
		None = 0,
		USBOnly = 1,
		NetworkOnly = 2,
		Combined = 3,
	}
}