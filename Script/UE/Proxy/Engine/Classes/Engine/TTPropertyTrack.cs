using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TTPropertyTrack")]
	public partial class FTTPropertyTrack : FTTTrackBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TTPropertyTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTTPropertyTrack()
		{
		}

		public static bool operator ==(FTTPropertyTrack A, FTTPropertyTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTTPropertyTrack A, FTTPropertyTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTTPropertyTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PropertyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyName, __InBuffer);
				}
			}
		}

		private static uint __PropertyName = 0;

	}
}