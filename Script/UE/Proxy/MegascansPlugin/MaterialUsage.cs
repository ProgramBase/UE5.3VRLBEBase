using Script.CoreUObject;
using Script.Library;

namespace Script.MegascansPlugin
{
	[PathName("/Script/MegascansPlugin.MaterialUsage")]
	public partial class FMaterialUsage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MegascansPlugin.MaterialUsage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialUsage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialUsage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialUsage A, FMaterialUsage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialUsage A, FMaterialUsage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialUsage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString instanceID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __instanceID, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __instanceID, __InBuffer);
				}
			}
		}

		public FString materialSlot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __materialSlot, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __materialSlot, __InBuffer);
				}
			}
		}

		private static uint __instanceID = 0;

		private static uint __materialSlot = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}