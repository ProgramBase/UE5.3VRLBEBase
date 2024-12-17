using Script.CoreUObject;
using Script.Library;
using Script.AnimationCore;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ConstraintTarget")]
	public partial class FConstraintTarget : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.ConstraintTarget");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConstraintTarget() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FConstraintTarget() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FConstraintTarget A, FConstraintTarget B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConstraintTarget A, FConstraintTarget B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConstraintTarget;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTransform Transform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __InBuffer);
				}
			}
		}

		public float Weight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __InBuffer);
				}
			}
		}

		public bool bMaintainOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMaintainOffset, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMaintainOffset, __InBuffer);
				}
			}
		}

		public FTransformFilter Filter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Filter, __ReturnBuffer);

					return *(FTransformFilter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Filter, __InBuffer);
				}
			}
		}

		private static uint __Transform = 0;

		private static uint __Weight = 0;

		private static uint __bMaintainOffset = 0;

		private static uint __Filter = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}