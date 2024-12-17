using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.DataLayerEditor
{
	[PathName("/Script/DataLayerEditor.DataLayerFactory")]
	public partial class UDataLayerFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataLayerEditor.DataLayerFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}