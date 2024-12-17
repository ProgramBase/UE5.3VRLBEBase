using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.InteractiveFoliageComponent")]
	public partial class UInteractiveFoliageComponent : UStaticMeshComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.InteractiveFoliageComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}