using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PerBoneInterpolation")]
	public partial class FPerBoneInterpolation : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PerBoneInterpolation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerBoneInterpolation() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerBoneInterpolation() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerBoneInterpolation A, FPerBoneInterpolation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerBoneInterpolation A, FPerBoneInterpolation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerBoneInterpolation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBoneReference BoneReference
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneReference, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneReference, __InBuffer);
				}
			}
		}

		public float InterpolationSpeedPerSec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterpolationSpeedPerSec, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterpolationSpeedPerSec, __InBuffer);
				}
			}
		}

		private static uint __BoneReference = 0;

		private static uint __InterpolationSpeedPerSec = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}