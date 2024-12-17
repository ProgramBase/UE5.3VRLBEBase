using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimBlueprintExtension_Attributes")]
	public partial class UAnimBlueprintExtension_Attributes : UAnimBlueprintExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimBlueprintExtension_Attributes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}