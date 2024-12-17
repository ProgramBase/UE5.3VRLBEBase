using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimTrack")]
	public partial class FAnimTrack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimTrack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimTrack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimTrack A, FAnimTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimTrack A, FAnimTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAnimSegment> AnimSegments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimSegments, __ReturnBuffer);

					return *(TArray<FAnimSegment>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimSegments, __InBuffer);
				}
			}
		}

		private static uint __AnimSegments = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}