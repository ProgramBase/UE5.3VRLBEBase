using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotify_ResetClothingSimulation")]
	public partial class UAnimNotify_ResetClothingSimulation : UAnimNotify, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotify_ResetClothingSimulation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}