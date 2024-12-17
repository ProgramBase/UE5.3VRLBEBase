using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialFunctionMaterialLayerFactory")]
	public partial class UMaterialFunctionMaterialLayerFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialFunctionMaterialLayerFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}