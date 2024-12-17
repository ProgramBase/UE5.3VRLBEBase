using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryMode
{
	[PathName("/Script/GeometryMode.GeomModifier_Edit")]
	public partial class UGeomModifier_Edit : UGeomModifier, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryMode.GeomModifier_Edit");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}