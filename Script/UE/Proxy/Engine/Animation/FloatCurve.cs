using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FloatCurve")]
	public partial class FFloatCurve : FAnimCurveBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FloatCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFloatCurve()
		{
		}

		public static bool operator ==(FFloatCurve A, FFloatCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFloatCurve A, FFloatCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFloatCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRichCurve FloatCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatCurve, __ReturnBuffer);

					return *(FRichCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatCurve, __InBuffer);
				}
			}
		}

		private static uint __FloatCurve = 0;

	}
}