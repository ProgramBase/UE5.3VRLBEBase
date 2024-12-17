using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2")]
	public partial class FInAppPurchaseProductRequest2 : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/OnlineSubsystemUtils.InAppPurchaseProductRequest2");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInAppPurchaseProductRequest2() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInAppPurchaseProductRequest2() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInAppPurchaseProductRequest2 A, FInAppPurchaseProductRequest2 B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInAppPurchaseProductRequest2 A, FInAppPurchaseProductRequest2 B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInAppPurchaseProductRequest2;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ProductIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProductIdentifier, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProductIdentifier, __InBuffer);
				}
			}
		}

		public bool bIsConsumable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsConsumable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsConsumable, __InBuffer);
				}
			}
		}

		private static uint __ProductIdentifier = 0;

		private static uint __bIsConsumable = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}