using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EBakeScaleMethod")]
	public enum EBakeScaleMethod : byte
	{
		BakeFullScale = 0,
		BakeNonuniformScale = 1,
		DoNotBakeScale = 2,
	}
}