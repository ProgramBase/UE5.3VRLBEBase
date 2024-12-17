using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.EBoxLengthMeasurementMethod")]
	public enum EBoxLengthMeasurementMethod : byte
	{
		XAxis = 0,
		YAxis = 1,
		ZAxis = 2,
		ShortestAxis = 3,
		LongestAxis = 4,
		Diagonal = 5,
	}
}