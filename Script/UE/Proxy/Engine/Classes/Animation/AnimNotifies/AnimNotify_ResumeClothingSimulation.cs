using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotify_ResumeClothingSimulation")]
	public partial class UAnimNotify_ResumeClothingSimulation : UAnimNotify, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotify_ResumeClothingSimulation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}