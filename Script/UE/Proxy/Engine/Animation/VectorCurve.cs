using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VectorCurve")]
	public partial class FVectorCurve : FAnimCurveBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.VectorCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVectorCurve()
		{
		}

		public static bool operator ==(FVectorCurve A, FVectorCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVectorCurve A, FVectorCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVectorCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRichCurve FloatCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatCurves, __ReturnBuffer);

					return *(FRichCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatCurves, __InBuffer);
				}
			}
		}

		private static uint __FloatCurves = 0;

	}
}