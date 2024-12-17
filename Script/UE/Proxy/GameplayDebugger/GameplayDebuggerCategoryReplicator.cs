using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerCategoryReplicator")]
	public partial class AGameplayDebuggerCategoryReplicator : AActor, IStaticClass
	{
		public APlayerController OwnerPC
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerPC, __ReturnBuffer);

					return *(APlayerController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerPC, __InBuffer);
				}
			}
		}

		public bool bIsEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __InBuffer);
				}
			}
		}

		public FGameplayDebuggerNetPack ReplicatedData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedData, __ReturnBuffer);

					return *(FGameplayDebuggerNetPack*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedData, __InBuffer);
				}
			}
		}

		public FGameplayDebuggerDebugActor DebugActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugActor, __ReturnBuffer);

					return *(FGameplayDebuggerDebugActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugActor, __InBuffer);
				}
			}
		}

		public FGameplayDebuggerVisLogSync VisLogSync
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VisLogSync, __ReturnBuffer);

					return *(FGameplayDebuggerVisLogSync*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VisLogSync, __InBuffer);
				}
			}
		}

		public UGameplayDebuggerRenderingComponent RenderingComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderingComp, __ReturnBuffer);

					return *(UGameplayDebuggerRenderingComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderingComp, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayDebugger.GameplayDebuggerCategoryReplicator");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ServerSetViewPoint(FVector InViewLocation, FVector InViewDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InViewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InViewDirection?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSetViewPoint, __InBuffer);
			}
		}

		public virtual void ServerSetEnabled(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSetEnabled, __InBuffer);
			}
		}

		public virtual void ServerSetDebugActor(AActor Actor, bool bSelectInEditor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelectInEditor;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSetDebugActor, __InBuffer);
			}
		}

		public virtual void ServerSetCategoryEnabled(int CategoryId, bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = CategoryId;

				*(bool*)(__InBuffer + 4) = bEnable;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSetCategoryEnabled, __InBuffer);
			}
		}

		public virtual void ServerSendExtensionInputEvent(int ExtensionId, int HandlerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = ExtensionId;

				*(int*)(__InBuffer + 4) = HandlerId;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSendExtensionInputEvent, __InBuffer);
			}
		}

		public virtual void ServerSendCategoryInputEvent(int CategoryId, int HandlerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = CategoryId;

				*(int*)(__InBuffer + 4) = HandlerId;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerSendCategoryInputEvent, __InBuffer);
			}
		}

		public virtual void ServerResetViewPoint()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerResetViewPoint);
			}
		}

		public virtual void OnRep_ReplicatedData()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ReplicatedData);
			}
		}

		public virtual void ClientDataPackPacket(FGameplayDebuggerDataPackRPCParams Params)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Params?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientDataPackPacket, __InBuffer);
			}
		}

		private static uint __OwnerPC = 0;

		private static uint __bIsEnabled = 0;

		private static uint __ReplicatedData = 0;

		private static uint __DebugActor = 0;

		private static uint __VisLogSync = 0;

		private static uint __RenderingComp = 0;

		private static uint __ServerSetViewPoint = 0;

		private static uint __ServerSetEnabled = 0;

		private static uint __ServerSetDebugActor = 0;

		private static uint __ServerSetCategoryEnabled = 0;

		private static uint __ServerSendExtensionInputEvent = 0;

		private static uint __ServerSendCategoryInputEvent = 0;

		private static uint __ServerResetViewPoint = 0;

		private static uint __OnRep_ReplicatedData = 0;

		private static uint __ClientDataPackPacket = 0;
	}
}