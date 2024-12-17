using Script.CoreUObject;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.PropertyValueVisibility")]
	public partial class UPropertyValueVisibility : UPropertyValue, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.PropertyValueVisibility");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}