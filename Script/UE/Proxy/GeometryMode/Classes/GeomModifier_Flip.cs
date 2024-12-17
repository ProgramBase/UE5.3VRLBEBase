using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryMode
{
	[PathName("/Script/GeometryMode.GeomModifier_Flip")]
	public partial class UGeomModifier_Flip : UGeomModifier_Edit, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryMode.GeomModifier_Flip");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}