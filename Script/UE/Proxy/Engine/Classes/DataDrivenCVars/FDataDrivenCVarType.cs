using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.FDataDrivenCVarType")]
	public enum FDataDrivenCVarType : byte
	{
		CVarFloat = 0,
		CVarInt = 1,
		CVarBool = 2,
	}
}