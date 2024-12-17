using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.AnimationSharingStateProcessor")]
	public partial class UAnimationSharingStateProcessor : UObject, IStaticClass
	{
		public TSoftObjectPtr<UEnum> AnimationStateEnum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationStateEnum, __ReturnBuffer);

					return *(TSoftObjectPtr<UEnum>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationStateEnum, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationSharing.AnimationSharingStateProcessor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ProcessActorState(ref int OutState, AActor InActor, byte CurrentState, byte OnDemandState, ref bool bShouldProcess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(int*)(__InBuffer) = OutState;

				*(nint*)(__InBuffer + 4) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = CurrentState;

				*(byte*)(__InBuffer + 13) = OnDemandState;

				*(bool*)(__InBuffer + 14) = bShouldProcess;

				var __OutBuffer = stackalloc byte[5];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ProcessActorState, __InBuffer, __OutBuffer);

				OutState = *(int*)(__OutBuffer);

				bShouldProcess = *(bool*)(__OutBuffer + 4);

			}
		}

		public virtual UEnum GetAnimationStateEnum()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnimationStateEnum, __ReturnBuffer);

				return *(UEnum*)__ReturnBuffer;
			}
		}

		private static uint __AnimationStateEnum = 0;

		private static uint __ProcessActorState = 0;

		private static uint __GetAnimationStateEnum = 0;
	}
}