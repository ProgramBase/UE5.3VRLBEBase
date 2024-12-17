using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialLayerUsageCommandlet")]
	public partial class UMaterialLayerUsageCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialLayerUsageCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}