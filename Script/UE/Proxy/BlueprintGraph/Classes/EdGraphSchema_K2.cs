using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchema_K2")]
	public partial class UEdGraphSchema_K2 : UEdGraphSchema, IStaticClass
	{
		public TArray<FBlueprintCallableFunctionRedirect> EditoronlyBPFunctionRedirects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditoronlyBPFunctionRedirects, __ReturnBuffer);

					return *(TArray<FBlueprintCallableFunctionRedirect>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditoronlyBPFunctionRedirects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.EdGraphSchema_K2");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditoronlyBPFunctionRedirects = 0;
	}
}