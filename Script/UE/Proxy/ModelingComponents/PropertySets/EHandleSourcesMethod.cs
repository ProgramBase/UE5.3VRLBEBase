using Script.CoreUObject;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.EHandleSourcesMethod")]
	public enum EHandleSourcesMethod : byte
	{
		DeleteSources = 0,
		HideSources = 1,
		KeepSources = 2,
		KeepFirstSource = 3,
		KeepLastSource = 4,
	}
}