using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TTLinearColorTrack")]
	public partial class FTTLinearColorTrack : FTTPropertyTrack, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TTLinearColorTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTTLinearColorTrack()
		{
		}

		public static bool operator ==(FTTLinearColorTrack A, FTTLinearColorTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTTLinearColorTrack A, FTTLinearColorTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTTLinearColorTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UCurveLinearColor CurveLinearColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveLinearColor, __ReturnBuffer);

					return *(UCurveLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveLinearColor, __InBuffer);
				}
			}
		}

		private static uint __CurveLinearColor = 0;

	}
}