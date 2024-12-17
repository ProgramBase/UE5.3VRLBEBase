using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryMode
{
	[PathName("/Script/GeometryMode.GeomModifier_Turn")]
	public partial class UGeomModifier_Turn : UGeomModifier_Edit, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryMode.GeomModifier_Turn");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}