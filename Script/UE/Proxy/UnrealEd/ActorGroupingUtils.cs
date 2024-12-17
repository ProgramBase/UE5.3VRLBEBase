using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorGroupingUtils")]
	public partial class UActorGroupingUtils : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorGroupingUtils");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnlockSelectedGroups()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UnlockSelectedGroups);
			}
		}

		public virtual void UngroupSelected()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UngroupSelected);
			}
		}

		public virtual void UngroupActors(TArray<AActor> ActorsToUngroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorsToUngroup?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UngroupActors, __InBuffer);
			}
		}

		public static void SetGroupingActive(bool bInGroupingActive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInGroupingActive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetGroupingActive, __InBuffer);
			}
		}

		public virtual void RemoveSelectedFromGroup()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveSelectedFromGroup);
			}
		}

		public virtual void LockSelectedGroups()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __LockSelectedGroups);
			}
		}

		public static bool IsGroupingActive()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsGroupingActive, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual AGroupActor GroupSelected()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GroupSelected, __ReturnBuffer);

				return *(AGroupActor*)__ReturnBuffer;
			}
		}

		public virtual AGroupActor GroupActors(TArray<AActor> ActorsToGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorsToGroup?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GroupActors, __InBuffer, __ReturnBuffer);

				return *(AGroupActor*)__ReturnBuffer;
			}
		}

		public static UActorGroupingUtils Get()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Get, __ReturnBuffer);

				return *(UActorGroupingUtils*)__ReturnBuffer;
			}
		}

		public virtual void AddSelectedToGroup()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AddSelectedToGroup);
			}
		}

		private static uint __UnlockSelectedGroups = 0;

		private static uint __UngroupSelected = 0;

		private static uint __UngroupActors = 0;

		private static uint __SetGroupingActive = 0;

		private static uint __RemoveSelectedFromGroup = 0;

		private static uint __LockSelectedGroups = 0;

		private static uint __IsGroupingActive = 0;

		private static uint __GroupSelected = 0;

		private static uint __GroupActors = 0;

		private static uint __Get = 0;

		private static uint __AddSelectedToGroup = 0;
	}
}