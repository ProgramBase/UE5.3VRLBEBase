using Script.CoreUObject;
using Script.Library;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.XRGestureConfig")]
	public partial class FXRGestureConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HeadMountedDisplay.XRGestureConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FXRGestureConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FXRGestureConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FXRGestureConfig A, FXRGestureConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FXRGestureConfig A, FXRGestureConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FXRGestureConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bTap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTap, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTap, __InBuffer);
				}
			}
		}

		public bool bHold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHold, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHold, __InBuffer);
				}
			}
		}

		public ESpatialInputGestureAxis AxisGesture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AxisGesture, __ReturnBuffer);

					return *(ESpatialInputGestureAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AxisGesture, __InBuffer);
				}
			}
		}

		public bool bNavigationAxisX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNavigationAxisX, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNavigationAxisX, __InBuffer);
				}
			}
		}

		public bool bNavigationAxisY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNavigationAxisY, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNavigationAxisY, __InBuffer);
				}
			}
		}

		public bool bNavigationAxisZ
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNavigationAxisZ, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNavigationAxisZ, __InBuffer);
				}
			}
		}

		private static uint __bTap = 0;

		private static uint __bHold = 0;

		private static uint __AxisGesture = 0;

		private static uint __bNavigationAxisX = 0;

		private static uint __bNavigationAxisY = 0;

		private static uint __bNavigationAxisZ = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}