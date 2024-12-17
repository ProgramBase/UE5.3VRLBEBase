using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EMeshCutDistribution")]
	public enum EMeshCutDistribution : int
	{
		SingleCut = 0,
		UniformRandom = 1,
		Grid = 2,
	}
}