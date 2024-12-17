using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISenseBlueprintListener")]
	public partial class UAISenseBlueprintListener : UUserDefinedStruct, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISenseBlueprintListener");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}