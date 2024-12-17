using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.GeometryCollectionEditor
{
	[PathName("/Script/GeometryCollectionEditor.ActorFactoryGeometryCollection")]
	public partial class UActorFactoryGeometryCollection : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEditor.ActorFactoryGeometryCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}