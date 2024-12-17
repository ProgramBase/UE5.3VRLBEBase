using Script.CoreUObject;
using Script.Library;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRigRetargetChainSettings")]
	public partial class FIKRigRetargetChainSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRigEditor.IKRigRetargetChainSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIKRigRetargetChainSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FIKRigRetargetChainSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FIKRigRetargetChainSettings A, FIKRigRetargetChainSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIKRigRetargetChainSettings A, FIKRigRetargetChainSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIKRigRetargetChainSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ChainName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChainName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChainName, __InBuffer);
				}
			}
		}

		public FName StartBone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StartBone, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StartBone, __InBuffer);
				}
			}
		}

		public FName EndBone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EndBone, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EndBone, __InBuffer);
				}
			}
		}

		private static uint __ChainName = 0;

		private static uint __StartBone = 0;

		private static uint __EndBone = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}