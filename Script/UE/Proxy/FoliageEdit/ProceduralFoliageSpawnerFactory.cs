using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.FoliageEdit
{
	[PathName("/Script/FoliageEdit.ProceduralFoliageSpawnerFactory")]
	public partial class UProceduralFoliageSpawnerFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FoliageEdit.ProceduralFoliageSpawnerFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}