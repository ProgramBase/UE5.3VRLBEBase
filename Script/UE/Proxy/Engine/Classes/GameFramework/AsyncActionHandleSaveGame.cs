using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AsyncActionHandleSaveGame")]
	public partial class UAsyncActionHandleSaveGame : UBlueprintAsyncActionBase, IStaticClass
	{
		public FOnAsyncHandleSaveGame Completed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Completed, __ReturnBuffer);

					return *(FOnAsyncHandleSaveGame*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Completed, __InBuffer);
				}
			}
		}

		public USaveGame SaveGameObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SaveGameObject, __ReturnBuffer);

					return *(USaveGame*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SaveGameObject, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AsyncActionHandleSaveGame");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="SaveGameObject">
		/// Object that contains data about the save game that we want to write out.
		/// </param>
		/// <param name="SlotName">
		/// Name of the save game slot to load from.
		/// </param>
		/// <param name="UserIndex">
		/// The platform user index that identifies the user doing the saving, ignored on some platforms.
		/// </param>
		public static UAsyncActionHandleSaveGame AsyncSaveGameToSlot(UObject WorldContextObject, USaveGame SaveGameObject, FString SlotName, int UserIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SaveGameObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = UserIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncSaveGameToSlot, __InBuffer, __ReturnBuffer);

				return *(UAsyncActionHandleSaveGame*)__ReturnBuffer;
			}
		}

		/// <param name="SlotName">
		/// Name of the save game slot to load from.
		/// </param>
		/// <param name="UserIndex">
		/// The platform user index that identifies the user doing the saving, ignored on some platforms.
		/// </param>
		public static UAsyncActionHandleSaveGame AsyncLoadGameFromSlot(UObject WorldContextObject, FString SlotName, int UserIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = UserIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncLoadGameFromSlot, __InBuffer, __ReturnBuffer);

				return *(UAsyncActionHandleSaveGame*)__ReturnBuffer;
			}
		}

		private static uint __Completed = 0;

		private static uint __SaveGameObject = 0;

		private static uint __AsyncSaveGameToSlot = 0;

		private static uint __AsyncLoadGameFromSlot = 0;
	}
}