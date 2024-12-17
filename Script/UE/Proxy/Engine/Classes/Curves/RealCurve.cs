using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RealCurve")]
	public partial class FRealCurve : FIndexedCurve, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RealCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRealCurve()
		{
		}

		public static bool operator ==(FRealCurve A, FRealCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRealCurve A, FRealCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRealCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		public ERichCurveExtrapolation PreInfinityExtrap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreInfinityExtrap, __ReturnBuffer);

					return *(ERichCurveExtrapolation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreInfinityExtrap, __InBuffer);
				}
			}
		}

		public ERichCurveExtrapolation PostInfinityExtrap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PostInfinityExtrap, __ReturnBuffer);

					return *(ERichCurveExtrapolation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PostInfinityExtrap, __InBuffer);
				}
			}
		}

		private static uint __DefaultValue = 0;

		private static uint __PreInfinityExtrap = 0;

		private static uint __PostInfinityExtrap = 0;

	}
}