using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VariantManagerContentEditor
{
	[PathName("/Script/VariantManagerContentEditor.VariantManagerFactoryNew")]
	public partial class UVariantManagerFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContentEditor.VariantManagerFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}