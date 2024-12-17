using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.FrameRate")]
	public partial class FFrameRate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.FrameRate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFrameRate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFrameRate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFrameRate A, FFrameRate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFrameRate A, FFrameRate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFrameRate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Numerator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Numerator, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Numerator, __InBuffer);
				}
			}
		}

		public int Denominator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Denominator, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Denominator, __InBuffer);
				}
			}
		}

		private static uint __Numerator = 0;

		private static uint __Denominator = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}