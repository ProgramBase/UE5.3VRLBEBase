using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EOccludedGeometryFilteringPolicy")]
	public enum EOccludedGeometryFilteringPolicy : byte
	{
		NoOcclusionFiltering = 0,
		VisibilityBasedFiltering = 1,
	}
}