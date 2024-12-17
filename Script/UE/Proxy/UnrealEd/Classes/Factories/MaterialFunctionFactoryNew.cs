using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialFunctionFactoryNew")]
	public partial class UMaterialFunctionFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialFunctionFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}