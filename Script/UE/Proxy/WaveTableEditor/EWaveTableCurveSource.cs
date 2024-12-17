using Script.CoreUObject;

namespace Script.WaveTableEditor
{
	[PathName("/Script/WaveTableEditor.EWaveTableCurveSource")]
	public enum EWaveTableCurveSource : long
	{
		Custom = 0,
		Expression = 1,
		Shared = 2,
		Unset = 3,
	}
}