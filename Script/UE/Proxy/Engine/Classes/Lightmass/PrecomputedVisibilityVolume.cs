using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PrecomputedVisibilityVolume")]
	public partial class APrecomputedVisibilityVolume : AVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PrecomputedVisibilityVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}