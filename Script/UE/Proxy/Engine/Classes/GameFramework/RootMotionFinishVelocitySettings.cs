using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RootMotionFinishVelocitySettings")]
	public partial class FRootMotionFinishVelocitySettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RootMotionFinishVelocitySettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRootMotionFinishVelocitySettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRootMotionFinishVelocitySettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRootMotionFinishVelocitySettings A, FRootMotionFinishVelocitySettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRootMotionFinishVelocitySettings A, FRootMotionFinishVelocitySettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRootMotionFinishVelocitySettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERootMotionFinishVelocityMode Mode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mode, __ReturnBuffer);

					return *(ERootMotionFinishVelocityMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mode, __InBuffer);
				}
			}
		}

		public FVector SetVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SetVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SetVelocity, __InBuffer);
				}
			}
		}

		public float ClampVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClampVelocity, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClampVelocity, __InBuffer);
				}
			}
		}

		private static uint __Mode = 0;

		private static uint __SetVelocity = 0;

		private static uint __ClampVelocity = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}