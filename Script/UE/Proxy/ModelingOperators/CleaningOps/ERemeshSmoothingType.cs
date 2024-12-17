using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.ERemeshSmoothingType")]
	public enum ERemeshSmoothingType : byte
	{
		Uniform = 0,
		Cotangent = 1,
		MeanValue = 2,
	}
}