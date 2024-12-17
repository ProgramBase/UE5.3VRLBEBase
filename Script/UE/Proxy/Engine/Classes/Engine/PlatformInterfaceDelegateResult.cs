using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlatformInterfaceDelegateResult")]
	public partial class FPlatformInterfaceDelegateResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PlatformInterfaceDelegateResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlatformInterfaceDelegateResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlatformInterfaceDelegateResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlatformInterfaceDelegateResult A, FPlatformInterfaceDelegateResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlatformInterfaceDelegateResult A, FPlatformInterfaceDelegateResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlatformInterfaceDelegateResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bSuccessful
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSuccessful, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSuccessful, __InBuffer);
				}
			}
		}

		public FPlatformInterfaceData Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(FPlatformInterfaceData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Data, __InBuffer);
				}
			}
		}

		private static uint __bSuccessful = 0;

		private static uint __Data = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}