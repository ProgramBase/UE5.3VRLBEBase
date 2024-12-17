using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DiffAssetsCommandlet")]
	public partial class UDiffAssetsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DiffAssetsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}