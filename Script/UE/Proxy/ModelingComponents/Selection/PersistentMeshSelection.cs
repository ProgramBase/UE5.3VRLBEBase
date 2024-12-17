using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PersistentMeshSelection")]
	public partial class UDEPRECATED_PersistentMeshSelection : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PersistentMeshSelection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}