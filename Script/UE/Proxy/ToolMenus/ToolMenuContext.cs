using Script.CoreUObject;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenuContext")]
	public partial class FToolMenuContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ToolMenus.ToolMenuContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FToolMenuContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FToolMenuContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FToolMenuContext A, FToolMenuContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FToolMenuContext A, FToolMenuContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FToolMenuContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UObject> ContextObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ContextObjects, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ContextObjects, __InBuffer);
				}
			}
		}

		private static uint __ContextObjects = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}