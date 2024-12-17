using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DelegateArray")]
	public partial class FDelegateArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DelegateArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDelegateArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDelegateArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDelegateArray A, FDelegateArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDelegateArray A, FDelegateArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDelegateArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPlatformInterfaceDelegate> Delegates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Delegates, __ReturnBuffer);

					return *(TArray<FPlatformInterfaceDelegate>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Delegates, __InBuffer);
				}
			}
		}

		private static uint __Delegates = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}