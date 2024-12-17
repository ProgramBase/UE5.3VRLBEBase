using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMTemplateArgumentType")]
	public partial class FRigVMTemplateArgumentType : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMTemplateArgumentType");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMTemplateArgumentType() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMTemplateArgumentType() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMTemplateArgumentType A, FRigVMTemplateArgumentType B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMTemplateArgumentType A, FRigVMTemplateArgumentType B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMTemplateArgumentType;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName CPPType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CPPType, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CPPType, __InBuffer);
				}
			}
		}

		public UObject CPPTypeObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CPPTypeObject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CPPTypeObject, __InBuffer);
				}
			}
		}

		private static uint __CPPType = 0;

		private static uint __CPPTypeObject = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}