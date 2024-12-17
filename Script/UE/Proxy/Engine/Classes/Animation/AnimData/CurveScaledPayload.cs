using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurveScaledPayload")]
	public partial class FCurveScaledPayload : FCurvePayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CurveScaledPayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCurveScaledPayload()
		{
		}

		public static bool operator ==(FCurveScaledPayload A, FCurveScaledPayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCurveScaledPayload A, FCurveScaledPayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCurveScaledPayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Factor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Factor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Factor, __InBuffer);
				}
			}
		}

		public float Origin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Origin, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Origin, __InBuffer);
				}
			}
		}

		private static uint __Factor = 0;

		private static uint __Origin = 0;

	}
}