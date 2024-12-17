using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimBlueprintPostCompileValidation")]
	public partial class UAnimBlueprintPostCompileValidation : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimBlueprintPostCompileValidation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}