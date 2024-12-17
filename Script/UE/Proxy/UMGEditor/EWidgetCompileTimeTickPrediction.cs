using Script.CoreUObject;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.EWidgetCompileTimeTickPrediction")]
	public enum EWidgetCompileTimeTickPrediction : byte
	{
		WontTick = 0,
		OnDemand = 1,
		WillTick = 2,
	}
}