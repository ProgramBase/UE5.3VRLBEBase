using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCommonParser
{
	[PathName("/Script/InterchangeCommonParser.InterchangeCurve")]
	public partial class FInterchangeCurve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeCommonParser.InterchangeCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeCurve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeCurve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeCurve A, FInterchangeCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeCurve A, FInterchangeCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FInterchangeCurveKey> Keys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Keys, __ReturnBuffer);

					return *(TArray<FInterchangeCurveKey>*)__ReturnBuffer;
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

		public nint GarbageCollectionHandle { get; set; }
	}
}