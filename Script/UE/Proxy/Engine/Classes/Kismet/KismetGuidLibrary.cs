using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetGuidLibrary")]
	public partial class UKismetGuidLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetGuidLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void Parse_StringToGuid(FString GuidString, ref FGuid OutGuid, ref bool Success)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = GuidString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutGuid?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Success;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Parse_StringToGuid, __InBuffer, __OutBuffer);

				OutGuid = *(FGuid*)(__OutBuffer);

				Success = *(bool*)(__OutBuffer + 8);

			}
		}

		public static bool NotEqual_GuidGuid(FGuid A, FGuid B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_GuidGuid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FGuid NewGuid()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __NewGuid, __ReturnBuffer);

				return *(FGuid*)__ReturnBuffer;
			}
		}

		public static bool IsValid_Guid(FGuid InGuid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGuid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValid_Guid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void Invalidate_Guid(ref FGuid InGuid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGuid?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Invalidate_Guid, __InBuffer, __OutBuffer);

				InGuid = *(FGuid*)(__OutBuffer);

			}
		}

		public static bool EqualEqual_GuidGuid(FGuid A, FGuid B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_GuidGuid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString Conv_GuidToString(FGuid InGuid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGuid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_GuidToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __Parse_StringToGuid = 0;

		private static uint __NotEqual_GuidGuid = 0;

		private static uint __NewGuid = 0;

		private static uint __IsValid_Guid = 0;

		private static uint __Invalidate_Guid = 0;

		private static uint __EqualEqual_GuidGuid = 0;

		private static uint __Conv_GuidToString = 0;
	}
}