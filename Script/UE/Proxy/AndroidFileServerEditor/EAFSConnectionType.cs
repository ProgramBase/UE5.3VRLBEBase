using Script.CoreUObject;

namespace Script.AndroidFileServerEditor
{
	[PathName("/Script/AndroidFileServerEditor.EAFSConnectionType")]
	public enum EAFSConnectionType : byte
	{
		USBOnly = 0,
		NetworkOnly = 1,
		Combined = 2,
	}
}