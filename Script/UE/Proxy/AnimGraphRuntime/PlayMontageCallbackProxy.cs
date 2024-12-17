using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.PlayMontageCallbackProxy")]
	public partial class UPlayMontageCallbackProxy : UObject, IStaticClass
	{
		public FOnMontagePlayDelegate OnCompleted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnCompleted, __ReturnBuffer);

					return *(FOnMontagePlayDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnCompleted, __InBuffer);
				}
			}
		}

		public FOnMontagePlayDelegate OnBlendOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnBlendOut, __ReturnBuffer);

					return *(FOnMontagePlayDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnBlendOut, __InBuffer);
				}
			}
		}

		public FOnMontagePlayDelegate OnInterrupted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInterrupted, __ReturnBuffer);

					return *(FOnMontagePlayDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInterrupted, __InBuffer);
				}
			}
		}

		public FOnMontagePlayDelegate OnNotifyBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnNotifyBegin, __ReturnBuffer);

					return *(FOnMontagePlayDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnNotifyBegin, __InBuffer);
				}
			}
		}

		public FOnMontagePlayDelegate OnNotifyEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnNotifyEnd, __ReturnBuffer);

					return *(FOnMontagePlayDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnNotifyEnd, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.PlayMontageCallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnNotifyEndReceived(FName NotifyName, FBranchingPointNotifyPayload BranchingPointNotifyPayload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NotifyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BranchingPointNotifyPayload?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnNotifyEndReceived, __InBuffer);
			}
		}

		public virtual void OnNotifyBeginReceived(FName NotifyName, FBranchingPointNotifyPayload BranchingPointNotifyPayload)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NotifyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BranchingPointNotifyPayload?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnNotifyBeginReceived, __InBuffer);
			}
		}

		public virtual void OnMontageEnded(UAnimMontage Montage, bool bInterrupted)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInterrupted;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnMontageEnded, __InBuffer);
			}
		}

		public virtual void OnMontageBlendingOut(UAnimMontage Montage, bool bInterrupted)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Montage?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bInterrupted;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnMontageBlendingOut, __InBuffer);
			}
		}

		public static UPlayMontageCallbackProxy CreateProxyObjectForPlayMontage(USkeletalMeshComponent InSkeletalMeshComponent, UAnimMontage MontageToPlay, float PlayRate = 1.000000f, float StartingPosition = 0.000000f, FName StartingSection = null)
		{
			unsafe
			{
				StartingSection ??= new FName("None");

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InSkeletalMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MontageToPlay?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = PlayRate;

				*(float*)(__InBuffer + 20) = StartingPosition;

				*(nint*)(__InBuffer + 24) = StartingSection?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForPlayMontage, __InBuffer, __ReturnBuffer);

				return *(UPlayMontageCallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __OnCompleted = 0;

		private static uint __OnBlendOut = 0;

		private static uint __OnInterrupted = 0;

		private static uint __OnNotifyBegin = 0;

		private static uint __OnNotifyEnd = 0;

		private static uint __OnNotifyEndReceived = 0;

		private static uint __OnNotifyBeginReceived = 0;

		private static uint __OnMontageEnded = 0;

		private static uint __OnMontageBlendingOut = 0;

		private static uint __CreateProxyObjectForPlayMontage = 0;
	}
}