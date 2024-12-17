using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldOutputType")]
	public enum EFieldOutputType : long
	{
		Field_Output_Vector = 0,
		Field_Output_Scalar = 1,
		Field_Output_Integer = 2,
		Field_Output_Max = 3,
	}
}