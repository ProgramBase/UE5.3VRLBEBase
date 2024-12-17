using Script.CoreUObject;
using Script.Library;

namespace Script.WaveTable
{
	[PathName("/Script/WaveTable.WaveTableBankEntry")]
	public partial class FWaveTableBankEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/WaveTable.WaveTableBankEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWaveTableBankEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWaveTableBankEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWaveTableBankEntry A, FWaveTableBankEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWaveTableBankEntry A, FWaveTableBankEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWaveTableBankEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FWaveTableTransform Transform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __ReturnBuffer);

					return *(FWaveTableTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __InBuffer);
				}
			}
		}

		private static uint __Transform = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}