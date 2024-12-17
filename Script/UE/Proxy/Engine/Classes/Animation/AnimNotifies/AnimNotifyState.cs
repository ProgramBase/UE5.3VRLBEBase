using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotifyState")]
	public partial class UAnimNotifyState : UObject, IStaticClass
	{
		public FColor NotifyColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyColor, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyColor, __InBuffer);
				}
			}
		}

		public bool bShouldFireInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldFireInEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldFireInEditor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotifyState");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool Received_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime, FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = MeshComp?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = FrameDeltaTime;

				*(nint*)(__InBuffer + 20) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __Received_NotifyTick, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool Received_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MeshComp?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __Received_NotifyEnd, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool Received_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration, FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = MeshComp?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = TotalDuration;

				*(nint*)(__InBuffer + 20) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __Received_NotifyBegin, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetNotifyName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNotifyName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual float GetDefaultTriggerWeightThreshold()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDefaultTriggerWeightThreshold, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __NotifyColor = 0;

		private static uint __bShouldFireInEditor = 0;

		private static uint __Received_NotifyTick = 0;

		private static uint __Received_NotifyEnd = 0;

		private static uint __Received_NotifyBegin = 0;

		private static uint __GetNotifyName = 0;

		private static uint __GetDefaultTriggerWeightThreshold = 0;
	}
}