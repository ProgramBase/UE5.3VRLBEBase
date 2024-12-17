using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECanBeCharacterBase")]
	public enum ECanBeCharacterBase : byte
	{
		ECB_No = 0,
		ECB_Yes = 1,
		ECB_Owner = 2,
	}
}