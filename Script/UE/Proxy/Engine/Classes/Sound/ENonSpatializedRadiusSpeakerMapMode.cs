using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENonSpatializedRadiusSpeakerMapMode")]
	public enum ENonSpatializedRadiusSpeakerMapMode : byte
	{
		OmniDirectional = 0,
		Direct2D = 1,
		Surround2D = 2,
	}
}