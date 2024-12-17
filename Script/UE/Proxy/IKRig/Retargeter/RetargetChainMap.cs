using Script.CoreUObject;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.RetargetChainMap")]
	public partial class FRetargetChainMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRig.RetargetChainMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRetargetChainMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRetargetChainMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRetargetChainMap A, FRetargetChainMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRetargetChainMap A, FRetargetChainMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRetargetChainMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName SourceChain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceChain, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceChain, __InBuffer);
				}
			}
		}

		public FName TargetChain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetChain, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetChain, __InBuffer);
				}
			}
		}

		private static uint __SourceChain = 0;

		private static uint __TargetChain = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}