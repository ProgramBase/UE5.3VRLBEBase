using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EHierarchicalSimplificationMethod")]
	public enum EHierarchicalSimplificationMethod : byte
	{
		None = 0,
		Merge = 1,
		Simplify = 2,
		Approximate = 3,
	}
}