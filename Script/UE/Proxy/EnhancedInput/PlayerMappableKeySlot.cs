using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.PlayerMappableKeySlot")]
	public partial class FPlayerMappableKeySlot : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.PlayerMappableKeySlot");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlayerMappableKeySlot() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlayerMappableKeySlot() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlayerMappableKeySlot A, FPlayerMappableKeySlot B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlayerMappableKeySlot A, FPlayerMappableKeySlot B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlayerMappableKeySlot;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int SlotNumber
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SlotNumber, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SlotNumber, __InBuffer);
				}
			}
		}

		private static uint __SlotNumber = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}