using Script.CoreUObject;
using Script.Library;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.AdvancedCopyCustomization")]
	public partial class UAdvancedCopyCustomization : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetTools.AdvancedCopyCustomization");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}