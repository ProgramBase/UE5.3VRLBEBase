using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary")]
	public partial class ULinkedAnimGraphLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool HasLinkedAnimInstance(FLinkedAnimGraphReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasLinkedAnimInstance, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UAnimInstance GetLinkedAnimInstance(FLinkedAnimGraphReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLinkedAnimInstance, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public static void ConvertToLinkedAnimGraphPure(FAnimNodeReference Node, ref FLinkedAnimGraphReference LinkedAnimGraph, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LinkedAnimGraph?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToLinkedAnimGraphPure, __InBuffer, __OutBuffer);

				LinkedAnimGraph = *(FLinkedAnimGraphReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		public static FLinkedAnimGraphReference ConvertToLinkedAnimGraph(FAnimNodeReference Node, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToLinkedAnimGraph, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer);

				return *(FLinkedAnimGraphReference*)__ReturnBuffer;
			}
		}

		private static uint __HasLinkedAnimInstance = 0;

		private static uint __GetLinkedAnimInstance = 0;

		private static uint __ConvertToLinkedAnimGraphPure = 0;

		private static uint __ConvertToLinkedAnimGraph = 0;
	}
}