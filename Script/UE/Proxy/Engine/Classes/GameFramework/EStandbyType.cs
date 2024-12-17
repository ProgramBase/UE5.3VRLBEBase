using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EStandbyType")]
	public enum EStandbyType : long
	{
		STDBY_Rx = 0,
		STDBY_Tx = 1,
		STDBY_BadPing = 2,
	}
}