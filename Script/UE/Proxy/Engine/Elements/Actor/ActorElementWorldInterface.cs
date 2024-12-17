using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;
using Script.TypedElementRuntime;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorElementWorldInterface")]
	public partial class UActorElementWorldInterface : UObject, IStaticClass, ITypedElementWorldInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorElementWorldInterface");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetWorldTransform(FScriptTypedElementHandle InElementHandle, FTransform InTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetWorldTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetRelativeTransform(FScriptTypedElementHandle InElementHandle, FTransform InTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRelativeTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetPivotOffset(FScriptTypedElementHandle InElementHandle, FVector InPivotOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPivotOffset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetPivotOffset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OverrideWorld">
		/// Override the world in which the promotion might create new elements. Leave it to null to use the world from the handle.
		/// </param>
		public virtual FScriptTypedElementHandle PromoteElement(FScriptTypedElementHandle InElementHandle, UWorld OverrideWorld = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideWorld?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PromoteElement, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		public virtual void NotifyMovementStarted(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NotifyMovementStarted, __InBuffer);
			}
		}

		public virtual void NotifyMovementOngoing(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NotifyMovementOngoing, __InBuffer);
			}
		}

		public virtual void NotifyMovementEnded(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NotifyMovementEnded, __InBuffer);
			}
		}

		public virtual bool IsTemplateElement(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsTemplateElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetWorldTransform(FScriptTypedElementHandle InElementHandle, ref FTransform OutTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetWorldTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTransform = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetRelativeTransform(FScriptTypedElementHandle InElementHandle, ref FTransform OutTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetRelativeTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTransform = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetPivotOffset(FScriptTypedElementHandle InElementHandle, ref FVector OutPivotOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPivotOffset?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetPivotOffset, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPivotOffset = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UWorld GetOwnerWorld(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetOwnerWorld, __InBuffer, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		public virtual ULevel GetOwnerLevel(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetOwnerLevel, __InBuffer, __ReturnBuffer);

				return *(ULevel*)__ReturnBuffer;
			}
		}

		public virtual bool GetBounds(FScriptTypedElementHandle InElementHandle, ref FBoxSphereBounds OutBounds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutBounds?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBounds, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutBounds = *(FBoxSphereBounds*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Default version calls DuplicateElements with a single element.
		/// </note>
		public virtual FScriptTypedElementHandle DuplicateElement(FScriptTypedElementHandle InElementHandle, UWorld InWorld, FVector InLocationOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InLocationOffset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateElement, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Default version calls DeleteElements with a single element.
		/// </note>
		public virtual bool DeleteElement(FScriptTypedElementHandle InElementHandle, UWorld InWorld, UTypedElementSelectionSet InSelectionSet, FTypedElementDeletionOptions InDeletionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InDeletionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanPromoteElement(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanPromoteElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanMoveElement(FScriptTypedElementHandle InElementHandle, ETypedElementWorldType InWorldType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InWorldType;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanMoveElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanEditElement(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanEditElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanDuplicateElement(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanDuplicateElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanDeleteElement(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanDeleteElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __SetWorldTransform = 0;

		private static uint __SetRelativeTransform = 0;

		private static uint __SetPivotOffset = 0;

		private static uint __PromoteElement = 0;

		private static uint __NotifyMovementStarted = 0;

		private static uint __NotifyMovementOngoing = 0;

		private static uint __NotifyMovementEnded = 0;

		private static uint __IsTemplateElement = 0;

		private static uint __GetWorldTransform = 0;

		private static uint __GetRelativeTransform = 0;

		private static uint __GetPivotOffset = 0;

		private static uint __GetOwnerWorld = 0;

		private static uint __GetOwnerLevel = 0;

		private static uint __GetBounds = 0;

		private static uint __DuplicateElement = 0;

		private static uint __DeleteElement = 0;

		private static uint __CanPromoteElement = 0;

		private static uint __CanMoveElement = 0;

		private static uint __CanEditElement = 0;

		private static uint __CanDuplicateElement = 0;

		private static uint __CanDeleteElement = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}