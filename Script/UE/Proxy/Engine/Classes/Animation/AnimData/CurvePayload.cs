using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CurvePayload")]
	public partial class FCurvePayload : FEmptyPayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CurvePayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCurvePayload()
		{
		}

		public static bool operator ==(FCurvePayload A, FCurvePayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCurvePayload A, FCurvePayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCurvePayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAnimationCurveIdentifier Identifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __ReturnBuffer);

					return *(FAnimationCurveIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __InBuffer);
				}
			}
		}

		private static uint __Identifier = 0;

	}
}