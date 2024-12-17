using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PersistentDynamicMeshSource")]
	public partial class UPersistentDynamicMeshSource : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PersistentDynamicMeshSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/ModelingComponents.PersistentDynamicMeshSource")]
	public interface IPersistentDynamicMeshSource : IInterface
	{
	}
}