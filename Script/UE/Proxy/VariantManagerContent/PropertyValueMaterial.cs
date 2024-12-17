using Script.CoreUObject;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.PropertyValueMaterial")]
	public partial class UPropertyValueMaterial : UPropertyValue, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.PropertyValueMaterial");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}