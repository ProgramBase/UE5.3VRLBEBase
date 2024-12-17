using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.StaticMeshBackedTarget")]
	public partial class UStaticMeshBackedTarget : UAssetBackedTarget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.StaticMeshBackedTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.StaticMeshBackedTarget")]
	public interface IStaticMeshBackedTarget : IAssetBackedTarget
	{
	}
}