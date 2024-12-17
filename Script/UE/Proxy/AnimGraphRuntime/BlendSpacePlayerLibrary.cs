using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.BlendSpacePlayerLibrary")]
	public partial class UBlendSpacePlayerLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.BlendSpacePlayerLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SnapToPosition(FBlendSpacePlayerReference BlendSpacePlayer, FVector NewPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewPosition?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SnapToPosition, __InBuffer);
			}
		}

		public static bool ShouldResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ShouldResetPlayTimeWhenBlendSpaceChanges, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FBlendSpacePlayerReference SetResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer, bool bReset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bReset;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetResetPlayTimeWhenBlendSpaceChanges, __InBuffer, __ReturnBuffer);

				return *(FBlendSpacePlayerReference*)__ReturnBuffer;
			}
		}

		public static FBlendSpacePlayerReference SetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer, float PlayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PlayRate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetPlayRate, __InBuffer, __ReturnBuffer);

				return *(FBlendSpacePlayerReference*)__ReturnBuffer;
			}
		}

		public static FBlendSpacePlayerReference SetLoop(FBlendSpacePlayerReference BlendSpacePlayer, bool bLoop)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLoop;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetLoop, __InBuffer, __ReturnBuffer);

				return *(FBlendSpacePlayerReference*)__ReturnBuffer;
			}
		}

		public static FBlendSpacePlayerReference SetBlendSpaceWithInertialBlending(FAnimUpdateContext UpdateContext, FBlendSpacePlayerReference BlendSpacePlayer, UBlendSpace BlendSpace, float BlendTime = 0.200000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = UpdateContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BlendSpace?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = BlendTime;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetBlendSpaceWithInertialBlending, __InBuffer, __ReturnBuffer);

				return *(FBlendSpacePlayerReference*)__ReturnBuffer;
			}
		}

		public static FBlendSpacePlayerReference SetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer, UBlendSpace BlendSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BlendSpace?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetBlendSpace, __InBuffer, __ReturnBuffer);

				return *(FBlendSpacePlayerReference*)__ReturnBuffer;
			}
		}

		public static float GetStartPosition(FBlendSpacePlayerReference BlendSpacePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStartPosition, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FVector GetPosition(FBlendSpacePlayerReference BlendSpacePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static float GetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPlayRate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static bool GetLoop(FBlendSpacePlayerReference BlendSpacePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLoop, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UBlendSpace GetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlendSpace, __InBuffer, __ReturnBuffer);

				return *(UBlendSpace*)__ReturnBuffer;
			}
		}

		public static void ConvertToBlendSpacePlayerPure(FAnimNodeReference Node, ref FBlendSpacePlayerReference BlendSpacePlayer, ref bool Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BlendSpacePlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Result;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertToBlendSpacePlayerPure, __InBuffer, __OutBuffer);

				BlendSpacePlayer = *(FBlendSpacePlayerReference*)(__OutBuffer);

				Result = *(bool*)(__OutBuffer + 8);

			}
		}

		public static FBlendSpacePlayerReference ConvertToBlendSpacePlayer(FAnimNodeReference Node, ref EAnimNodeReferenceConversionResult Result)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Result;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvertToBlendSpacePlayer, __InBuffer, __OutBuffer, __ReturnBuffer);

				Result = *(EAnimNodeReferenceConversionResult*)(__OutBuffer);

				return *(FBlendSpacePlayerReference*)__ReturnBuffer;
			}
		}

		private static uint __SnapToPosition = 0;

		private static uint __ShouldResetPlayTimeWhenBlendSpaceChanges = 0;

		private static uint __SetResetPlayTimeWhenBlendSpaceChanges = 0;

		private static uint __SetPlayRate = 0;

		private static uint __SetLoop = 0;

		private static uint __SetBlendSpaceWithInertialBlending = 0;

		private static uint __SetBlendSpace = 0;

		private static uint __GetStartPosition = 0;

		private static uint __GetPosition = 0;

		private static uint __GetPlayRate = 0;

		private static uint __GetLoop = 0;

		private static uint __GetBlendSpace = 0;

		private static uint __ConvertToBlendSpacePlayerPure = 0;

		private static uint __ConvertToBlendSpacePlayer = 0;
	}
}