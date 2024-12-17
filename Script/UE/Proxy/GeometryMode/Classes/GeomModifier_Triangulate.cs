using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryMode
{
	[PathName("/Script/GeometryMode.GeomModifier_Triangulate")]
	public partial class UGeomModifier_Triangulate : UGeomModifier_Edit, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryMode.GeomModifier_Triangulate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}