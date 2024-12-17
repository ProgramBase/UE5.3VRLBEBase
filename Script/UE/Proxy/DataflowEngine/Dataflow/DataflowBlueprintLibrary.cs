using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DataflowEngine
{
	[PathName("/Script/DataflowEngine.DataflowBlueprintLibrary")]
	public partial class UDataflowBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataflowEngine.DataflowBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void EvaluateTerminalNodeByName(UDataflow Dataflow, FName TerminalNodeName, UObject ResultAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Dataflow?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TerminalNodeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ResultAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EvaluateTerminalNodeByName, __InBuffer);
			}
		}

		private static uint __EvaluateTerminalNodeByName = 0;
	}
}