using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialFunctionMaterialLayerInstanceFactory")]
	public partial class UMaterialFunctionMaterialLayerInstanceFactory : UMaterialFunctionInstanceFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialFunctionMaterialLayerInstanceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}