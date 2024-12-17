using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESpecularProfileFormat")]
	public enum ESpecularProfileFormat : byte
	{
		ViewLightVector = 0,
		HalfVector = 1,
	}
}