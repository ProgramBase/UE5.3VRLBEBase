using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.FoliageEdit
{
	[PathName("/Script/FoliageEdit.FoliageType_InstancedStaticMeshFactory")]
	public partial class UFoliageType_InstancedStaticMeshFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FoliageEdit.FoliageType_InstancedStaticMeshFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}