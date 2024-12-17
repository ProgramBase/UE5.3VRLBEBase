using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurveFlagsChangedPayload")]
	public partial class FCurveFlagsChangedPayload : FCurvePayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CurveFlagsChangedPayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCurveFlagsChangedPayload()
		{
		}

		public static bool operator ==(FCurveFlagsChangedPayload A, FCurveFlagsChangedPayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCurveFlagsChangedPayload A, FCurveFlagsChangedPayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCurveFlagsChangedPayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int OldFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OldFlags, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OldFlags, __InBuffer);
				}
			}
		}

		private static uint __OldFlags = 0;

	}
}