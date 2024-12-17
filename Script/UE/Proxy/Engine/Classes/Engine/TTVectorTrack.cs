using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TTVectorTrack")]
	public partial class FTTVectorTrack : FTTPropertyTrack, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TTVectorTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTTVectorTrack()
		{
		}

		public static bool operator ==(FTTVectorTrack A, FTTVectorTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTTVectorTrack A, FTTVectorTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTTVectorTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UCurveVector CurveVector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveVector, __ReturnBuffer);

					return *(UCurveVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveVector, __InBuffer);
				}
			}
		}

		private static uint __CurveVector = 0;

	}
}