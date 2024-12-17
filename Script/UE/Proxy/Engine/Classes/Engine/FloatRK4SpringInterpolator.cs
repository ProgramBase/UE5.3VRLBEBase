using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FloatRK4SpringInterpolator")]
	public partial class FFloatRK4SpringInterpolator : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FloatRK4SpringInterpolator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFloatRK4SpringInterpolator() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFloatRK4SpringInterpolator() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFloatRK4SpringInterpolator A, FFloatRK4SpringInterpolator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFloatRK4SpringInterpolator A, FFloatRK4SpringInterpolator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFloatRK4SpringInterpolator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float StiffnessConstant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StiffnessConstant, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StiffnessConstant, __InBuffer);
				}
			}
		}

		public float DampeningRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DampeningRatio, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DampeningRatio, __InBuffer);
				}
			}
		}

		private static uint __StiffnessConstant = 0;

		private static uint __DampeningRatio = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}