using Script.CoreUObject;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.PropertyValueColor")]
	public partial class UPropertyValueColor : UPropertyValue, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.PropertyValueColor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}