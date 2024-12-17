using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionDamagePropagationData")]
	public partial class FGeometryCollectionDamagePropagationData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionDamagePropagationData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionDamagePropagationData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionDamagePropagationData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionDamagePropagationData A, FGeometryCollectionDamagePropagationData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionDamagePropagationData A, FGeometryCollectionDamagePropagationData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionDamagePropagationData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnabled, __InBuffer);
				}
			}
		}

		public float BreakDamagePropagationFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BreakDamagePropagationFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BreakDamagePropagationFactor, __InBuffer);
				}
			}
		}

		public float ShockDamagePropagationFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShockDamagePropagationFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShockDamagePropagationFactor, __InBuffer);
				}
			}
		}

		private static uint __bEnabled = 0;

		private static uint __BreakDamagePropagationFactor = 0;

		private static uint __ShockDamagePropagationFactor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}