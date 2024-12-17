using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraStructConversionType")]
	public enum ENiagaraStructConversionType : byte
	{
		CopyOnly = 0,
		DoubleToFloat = 1,
		Vector2 = 2,
		Vector3 = 3,
		Vector4 = 4,
		Quat = 5,
	}
}