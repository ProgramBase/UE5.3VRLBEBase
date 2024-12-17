using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FrameRateChangedPayload")]
	public partial class FFrameRateChangedPayload : FEmptyPayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.FrameRateChangedPayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFrameRateChangedPayload()
		{
		}

		public static bool operator ==(FFrameRateChangedPayload A, FFrameRateChangedPayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFrameRateChangedPayload A, FFrameRateChangedPayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFrameRateChangedPayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameRate PreviousFrameRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreviousFrameRate, __ReturnBuffer);

					return *(FFrameRate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreviousFrameRate, __InBuffer);
				}
			}
		}

		private static uint __PreviousFrameRate = 0;

	}
}