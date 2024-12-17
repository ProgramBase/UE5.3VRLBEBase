using Script.CoreUObject;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.EFiBVersion")]
	public enum EFiBVersion : long
	{
		FIB_VER_NONE = -1,
		FIB_VER_BASE = 0,
		FIB_VER_VARIABLE_REFERENCE = 1,
		FIB_VER_INTERFACE_GRAPHS = 2,
		FIB_VER_PLUS_ONE = 3,
		FIB_VER_LATEST = 2,
	}
}