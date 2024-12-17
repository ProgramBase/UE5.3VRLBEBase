using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.Paper2DEditor
{
	[PathName("/Script/Paper2DEditor.TerrainSplineActorFactory")]
	public partial class UTerrainSplineActorFactory : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2DEditor.TerrainSplineActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}