using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotify_PauseClothingSimulation")]
	public partial class UAnimNotify_PauseClothingSimulation : UAnimNotify, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotify_PauseClothingSimulation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}