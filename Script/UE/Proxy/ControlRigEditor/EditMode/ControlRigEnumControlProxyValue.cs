using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigEnumControlProxyValue")]
	public partial class FControlRigEnumControlProxyValue : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.ControlRigEnumControlProxyValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigEnumControlProxyValue() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigEnumControlProxyValue() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigEnumControlProxyValue A, FControlRigEnumControlProxyValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigEnumControlProxyValue A, FControlRigEnumControlProxyValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigEnumControlProxyValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UEnum EnumType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EnumType, __ReturnBuffer);

					return *(UEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EnumType, __InBuffer);
				}
			}
		}

		public int EnumIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EnumIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EnumIndex, __InBuffer);
				}
			}
		}

		private static uint __EnumType = 0;

		private static uint __EnumIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}