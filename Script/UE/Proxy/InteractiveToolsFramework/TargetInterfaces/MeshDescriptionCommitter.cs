using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.MeshDescriptionCommitter")]
	public partial class UMeshDescriptionCommitter : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.MeshDescriptionCommitter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.MeshDescriptionCommitter")]
	public interface IMeshDescriptionCommitter : IInterface
	{
	}
}