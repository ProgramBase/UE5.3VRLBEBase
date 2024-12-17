using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryMode
{
	[PathName("/Script/GeometryMode.GeomModifier_Split")]
	public partial class UGeomModifier_Split : UGeomModifier_Edit, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryMode.GeomModifier_Split");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}