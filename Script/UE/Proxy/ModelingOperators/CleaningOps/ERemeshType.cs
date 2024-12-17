using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.ERemeshType")]
	public enum ERemeshType : byte
	{
		Standard = 0,
		FullPass = 1,
		NormalFlow = 2,
	}
}