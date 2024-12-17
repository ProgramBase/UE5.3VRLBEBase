using Script.CoreUObject;

namespace Script.ModelingOperatorsEditorOnly
{
	[PathName("/Script/ModelingOperatorsEditorOnly.EEmbeddedPolygonOpMethod")]
	public enum EEmbeddedPolygonOpMethod : byte
	{
		TrimOutside = 0,
		TrimInside = 1,
		InsertPolygon = 2,
		CutThrough = 3,
	}
}