using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimBlueprintGeneratedStruct")]
	public partial class UAnimBlueprintGeneratedStruct : UScriptStruct, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimBlueprintGeneratedStruct");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}