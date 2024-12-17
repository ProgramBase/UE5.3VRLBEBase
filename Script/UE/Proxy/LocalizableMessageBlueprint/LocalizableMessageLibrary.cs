using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.LocalizableMessage;

namespace Script.LocalizableMessageBlueprint
{
	[PathName("/Script/LocalizableMessageBlueprint.LocalizableMessageLibrary")]
	public partial class ULocalizableMessageLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LocalizableMessageBlueprint.LocalizableMessageLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void Reset_LocalizableMessage(ref FLocalizableMessage Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Message?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __Reset_LocalizableMessage, __InBuffer, __OutBuffer);

				Message = *(FLocalizableMessage*)(__OutBuffer);

			}
		}

		public static bool IsEmpty_LocalizableMessage(FLocalizableMessage Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Message?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsEmpty_LocalizableMessage, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FText Conv_LocalizableMessageToText(UObject WorldContextObject, FLocalizableMessage Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Message?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_LocalizableMessageToText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		private static uint __Reset_LocalizableMessage = 0;

		private static uint __IsEmpty_LocalizableMessage = 0;

		private static uint __Conv_LocalizableMessageToText = 0;
	}
}