using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.MaterialProvider")]
	public partial class UMaterialProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.MaterialProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.MaterialProvider")]
	public interface IMaterialProvider : IInterface
	{
	}
}