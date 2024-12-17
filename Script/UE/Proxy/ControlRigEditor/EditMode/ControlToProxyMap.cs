using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlToProxyMap")]
	public partial class FControlToProxyMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.ControlToProxyMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlToProxyMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlToProxyMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlToProxyMap A, FControlToProxyMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlToProxyMap A, FControlToProxyMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlToProxyMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, UControlRigControlsProxy> ControlToProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlToProxy, __ReturnBuffer);

					return *(TMap<FName, UControlRigControlsProxy>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlToProxy, __InBuffer);
				}
			}
		}

		private static uint __ControlToProxy = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}