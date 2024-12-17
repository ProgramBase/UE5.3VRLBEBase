using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCommonParser
{
	[PathName("/Script/InterchangeCommonParser.InterchangeStepCurve")]
	public partial class FInterchangeStepCurve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeCommonParser.InterchangeStepCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeStepCurve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeStepCurve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeStepCurve A, FInterchangeStepCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeStepCurve A, FInterchangeStepCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeStepCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<float> KeyTimes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyTimes, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyTimes, __InBuffer);
				}
			}
		}

		private static uint __KeyTimes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}