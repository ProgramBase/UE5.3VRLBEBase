using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryMode
{
	[PathName("/Script/GeometryMode.GeomModifier_Optimize")]
	public partial class UGeomModifier_Optimize : UGeomModifier_Triangulate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryMode.GeomModifier_Optimize");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}