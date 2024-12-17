using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.GeometryCollectionEditor
{
	[PathName("/Script/GeometryCollectionEditor.GeometryCollectionFactory")]
	public partial class UGeometryCollectionFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEditor.GeometryCollectionFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}