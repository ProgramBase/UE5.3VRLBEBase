using Script.CoreUObject;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.PropertyValueOption")]
	public partial class UPropertyValueOption : UPropertyValue, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.PropertyValueOption");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}