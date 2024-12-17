using Script.CoreUObject;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.PropertyValueTransform")]
	public partial class UPropertyValueTransform : UPropertyValue, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.PropertyValueTransform");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}