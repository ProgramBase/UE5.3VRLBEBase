using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialLayerLinkState")]
	public enum EMaterialLayerLinkState : byte
	{
		Uninitialized = 0,
		LinkedToParent = 1,
		UnlinkedFromParent = 2,
		NotFromParent = 3,
	}
}