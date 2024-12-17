using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReplaceAssetsCommandlet")]
	public partial class UReplaceAssetsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReplaceAssetsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}