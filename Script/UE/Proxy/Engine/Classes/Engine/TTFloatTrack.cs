using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TTFloatTrack")]
	public partial class FTTFloatTrack : FTTPropertyTrack, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TTFloatTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTTFloatTrack()
		{
		}

		public static bool operator ==(FTTFloatTrack A, FTTFloatTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTTFloatTrack A, FTTFloatTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTTFloatTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UCurveFloat CurveFloat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveFloat, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveFloat, __InBuffer);
				}
			}
		}

		private static uint __CurveFloat = 0;

	}
}