using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimExecutionContextLibrary")]
	public partial class UAnimExecutionContextLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.AnimExecutionContextLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Prototype_ThreadSafeAnimUpdateCall(FAnimUpdateContext Context, FAnimNodeReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Node?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Prototype_ThreadSafeAnimUpdateCall, __InBuffer);
			}
		}

		public virtual void Prototype_ThreadSafeAnimNodeCall(FAnimExecutionContext Context, FAnimNodeReference Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Node?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Prototype_ThreadSafeAnimNodeCall, __InBuffer);
			}
		}

		public static float GetDeltaTime(FAnimUpdateContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDeltaTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetCurrentWeight(FAnimUpdateContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentWeight, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FAnimNodeReference GetAnimNodeReference(UAnimInstance Instance, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Instance?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAnimNodeReference, __InBuffer, __ReturnBuffer);

				return *(FAnimNodeReference*)__ReturnBuffer;
			}
		}

		public static UAnimInstance GetAnimInstance(FAnimExecutionContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAnimInstance, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public static FAnimUpdateContext ConvertToUpdateContext(FAnimExecutionContext Context, ref EAnimExecutionContextConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToUpdateContext, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimExecutionContextConversionResult*)(__OutBuffer);

				return *(FAnimUpdateContext*)__ReturnBuffer;
			}
		}

		public static FAnimPoseContext ConvertToPoseContext(FAnimExecutionContext Context, ref EAnimExecutionContextConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToPoseContext, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimExecutionContextConversionResult*)(__OutBuffer);

				return *(FAnimPoseContext*)__ReturnBuffer;
			}
		}

		public static FAnimInitializationContext ConvertToInitializationContext(FAnimExecutionContext Context, ref EAnimExecutionContextConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToInitializationContext, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimExecutionContextConversionResult*)(__OutBuffer);

				return *(FAnimInitializationContext*)__ReturnBuffer;
			}
		}

		public static FAnimComponentSpacePoseContext ConvertToComponentSpacePoseContext(FAnimExecutionContext Context, ref EAnimExecutionContextConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToComponentSpacePoseContext, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimExecutionContextConversionResult*)(__OutBuffer);

				return *(FAnimComponentSpacePoseContext*)__ReturnBuffer;
			}
		}

		private static uint __Prototype_ThreadSafeAnimUpdateCall = 0;

		private static uint __Prototype_ThreadSafeAnimNodeCall = 0;

		private static uint __GetDeltaTime = 0;

		private static uint __GetCurrentWeight = 0;

		private static uint __GetAnimNodeReference = 0;

		private static uint __GetAnimInstance = 0;

		private static uint __ConvertToUpdateContext = 0;

		private static uint __ConvertToPoseContext = 0;

		private static uint __ConvertToInitializationContext = 0;

		private static uint __ConvertToComponentSpacePoseContext = 0;
	}
}