using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimBlueprintExtension_CallFunction")]
	public partial class UAnimBlueprintExtension_CallFunction : UAnimBlueprintExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimBlueprintExtension_CallFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}