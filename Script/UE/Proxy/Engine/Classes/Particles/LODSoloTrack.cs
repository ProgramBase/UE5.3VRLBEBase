using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LODSoloTrack")]
	public partial class FLODSoloTrack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LODSoloTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLODSoloTrack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLODSoloTrack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLODSoloTrack A, FLODSoloTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLODSoloTrack A, FLODSoloTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLODSoloTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> SoloEnableSetting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoloEnableSetting, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoloEnableSetting, __InBuffer);
				}
			}
		}

		private static uint __SoloEnableSetting = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}