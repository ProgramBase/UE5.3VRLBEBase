using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperTerrainSplineComponent")]
	public partial class UPaperTerrainSplineComponent : USplineComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperTerrainSplineComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}