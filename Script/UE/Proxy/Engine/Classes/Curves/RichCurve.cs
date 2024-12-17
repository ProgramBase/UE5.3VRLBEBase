using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RichCurve")]
	public partial class FRichCurve : FRealCurve, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RichCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRichCurve()
		{
		}

		public static bool operator ==(FRichCurve A, FRichCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRichCurve A, FRichCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRichCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRichCurveKey> Keys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Keys, __ReturnBuffer);

					return *(TArray<FRichCurveKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Keys, __InBuffer);
				}
			}
		}

		private static uint __Keys = 0;

	}
}