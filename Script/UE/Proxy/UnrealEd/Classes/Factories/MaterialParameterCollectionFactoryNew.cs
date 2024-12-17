using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialParameterCollectionFactoryNew")]
	public partial class UMaterialParameterCollectionFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialParameterCollectionFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}