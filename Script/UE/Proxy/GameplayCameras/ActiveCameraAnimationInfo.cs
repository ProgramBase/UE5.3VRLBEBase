using Script.CoreUObject;
using Script.Library;
using Script.TemplateSequence;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.ActiveCameraAnimationInfo")]
	public partial class FActiveCameraAnimationInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayCameras.ActiveCameraAnimationInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActiveCameraAnimationInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActiveCameraAnimationInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActiveCameraAnimationInfo A, FActiveCameraAnimationInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActiveCameraAnimationInfo A, FActiveCameraAnimationInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActiveCameraAnimationInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UCameraAnimationSequence Sequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sequence, __ReturnBuffer);

					return *(UCameraAnimationSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sequence, __InBuffer);
				}
			}
		}

		public FCameraAnimationParams Params
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Params, __ReturnBuffer);

					return *(FCameraAnimationParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Params, __InBuffer);
				}
			}
		}

		public FCameraAnimationHandle Handle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Handle, __ReturnBuffer);

					return *(FCameraAnimationHandle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Handle, __InBuffer);
				}
			}
		}

		public UCameraAnimationSequencePlayer Player
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Player, __ReturnBuffer);

					return *(UCameraAnimationSequencePlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Player, __InBuffer);
				}
			}
		}

		public UCameraAnimationSequenceCameraStandIn CameraStandIn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CameraStandIn, __ReturnBuffer);

					return *(UCameraAnimationSequenceCameraStandIn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CameraStandIn, __InBuffer);
				}
			}
		}

		public float EaseInCurrentTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EaseInCurrentTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EaseInCurrentTime, __InBuffer);
				}
			}
		}

		public float EaseOutCurrentTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EaseOutCurrentTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EaseOutCurrentTime, __InBuffer);
				}
			}
		}

		public bool bIsEasingIn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsEasingIn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsEasingIn, __InBuffer);
				}
			}
		}

		public bool bIsEasingOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsEasingOut, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsEasingOut, __InBuffer);
				}
			}
		}

		private static uint __Sequence = 0;

		private static uint __Params = 0;

		private static uint __Handle = 0;

		private static uint __Player = 0;

		private static uint __CameraStandIn = 0;

		private static uint __EaseInCurrentTime = 0;

		private static uint __EaseOutCurrentTime = 0;

		private static uint __bIsEasingIn = 0;

		private static uint __bIsEasingOut = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}