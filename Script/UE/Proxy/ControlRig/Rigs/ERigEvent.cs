using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigEvent")]
	public enum ERigEvent : byte
	{
		None = 0,
		RequestAutoKey = 1,
		OpenUndoBracket = 2,
		CloseUndoBracket = 3,
		Max = 4,
	}
}